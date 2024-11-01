using System;
using System.Collections.Generic;

namespace FitnessTracker
{
    // Base Activity class
    abstract class Activity
    {
        private DateTime date;
        private int minutes;

        public Activity(DateTime date, int minutes)
        {
            this.date = date;
            this.minutes = minutes;
        }

        public DateTime Date => date;
        public int Minutes => minutes;

        // Virtual methods for calculating distance, speed, and pace
        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        // Method to display activity summary
        public virtual string GetSummary()
        {
            return $"{Date:dd MMM yyyy} {this.GetType().Name} ({Minutes} min): Distance: {GetDistance():0.0} km, " +
                   $"Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
        }
    }

    // Running class
    class Running : Activity
    {
        private double distance;

        public Running(DateTime date, int minutes, double distance) : base(date, minutes)
        {
            this.distance = distance;
        }

        public override double GetDistance()
        {
            return distance;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / Minutes) * 60; // Speed in kph
        }

        public override double GetPace()
        {
            return Minutes / GetDistance(); // Pace in min per km
        }
    }

    // Cycling class
    class Cycling : Activity
    {
        private double speed;

        public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
        {
            this.speed = speed;
        }

        public override double GetDistance()
        {
            return (speed * Minutes) / 60; // Distance in km
        }

        public override double GetSpeed()
        {
            return speed;
        }

        public override double GetPace()
        {
            return 60 / GetSpeed(); // Pace in min per km
        }
    }

    // Swimming class
    class Swimming : Activity
    {
        private int laps;

        public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
        {
            this.laps = laps;
        }

        public override double GetDistance()
        {
            return (laps * 50) / 1000.0; // Convert meters to km
        }

        public override double GetSpeed()
        {
            return (GetDistance() / Minutes) * 60; // Speed in kph
        }

        public override double GetPace()
        {
            return Minutes / GetDistance(); // Pace in min per km
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // Create activities
            List<Activity> activities = new List<Activity>
            {
                new Running(new DateTime(2022, 11, 3), 30, 4.8),  // 4.8 km running
                new Cycling(new DateTime(2022, 11, 3), 45, 20),   // 20 kph cycling
                new Swimming(new DateTime(2022, 11, 3), 30, 40)   // 40 laps swimming
            };

            // Display summaries
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
