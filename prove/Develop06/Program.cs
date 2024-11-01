using System;

class Program
{
 using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    // Base Goal class
    abstract class Goal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Points { get; protected set; }
        public bool IsComplete { get; protected set; }

        public Goal(string name, string description, int points)
        {
            Name = name;
            Description = description;
            Points = points;
        }

        public abstract void RecordEvent();
        public abstract string DisplayStatus();
    }

    // SimpleGoal class for one-time goals
    class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

        public override void RecordEvent()
        {
            if (!IsComplete)
            {
                Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
                IsComplete = true;
            }
        }

        public override string DisplayStatus()
        {
            return $"[ {(IsComplete ? "X" : " ")} ] {Name} - {Description} ({Points} pts)";
        }
    }

    // EternalGoal class
    class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points) { }

        public override void RecordEvent()
        {
            Console.WriteLine($"Goal '{Name}' recorded! You earned {Points} points.");
        }

        public override string DisplayStatus()
        {
            return $"[ ∞ ] {Name} - {Description} ({Points} pts each time)";
        }
    }

    // ChecklistGoal class
    class ChecklistGoal : Goal
    {
        private int requiredCompletions;
        private int currentCompletions;
        private int bonusPoints;

        public ChecklistGoal(string name, string description, int points, int requiredCompletions, int bonusPoints)
            : base(name, description, points)
        {
            this.requiredCompletions = requiredCompletions;
            this.bonusPoints = bonusPoints;
            currentCompletions = 0;
        }

        public override void RecordEvent()
        {
            if (!IsComplete)
            {
                currentCompletions++;
                Console.WriteLine($"Recorded '{Name}' - Completed {currentCompletions}/{requiredCompletions} times");

                if (currentCompletions >= requiredCompletions)
                {
                    IsComplete = true;
                    Points += bonusPoints;
                    Console.WriteLine($"Goal '{Name}' completed! You earned {Points + bonusPoints} points in total.");
                }
            }
        }

        public override string DisplayStatus()
        {
            return $"[ {(IsComplete ? "X" : " ")} ] {Name} - {Description} ({Points} pts) " +
                   $"Completed {currentCompletions}/{requiredCompletions} times";
        }
    }

    // GoalManager class 
    class GoalManager
    {
        private List<Goal> goals;
        private int totalScore;

        public GoalManager()
        {
            goals = new List<Goal>();
            totalScore = 0;
        }

        public void AddGoal(Goal goal)
        {
            goals.Add(goal);
        }

        public void RecordEvent(int goalIndex)
        {
            if (goalIndex >= 0 && goalIndex < goals.Count)
            {
                Goal goal = goals[goalIndex];
                goal.RecordEvent();
                totalScore += goal.Points;
            }
        }

        public void DisplayGoals()
        {
            Console.WriteLine("Goals:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].DisplayStatus()}");
            }
            Console.WriteLine($"\nTotal Score: {totalScore}");
        }

        public void Save(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(totalScore);
                foreach (Goal goal in goals)
                {
                    writer.WriteLine($"{goal.GetType().Name}|{goal.Name}|{goal.Description}|{goal.Points}|{goal.IsComplete}");
                }
            }
        }

        public void Load(string filename)
        {
            if (File.Exists(filename))
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    totalScore = int.Parse(reader.ReadLine());
                    goals.Clear();

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        string type = parts[0];
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        bool isComplete = bool.Parse(parts[4]);

                        Goal goal = type switch
                        {
                            "SimpleGoal" => new SimpleGoal(name, description, points),
                            "EternalGoal" => new EternalGoal(name, description, points),
                            "ChecklistGoal" => new ChecklistGoal(name, description, points, 5, 50), // Example values
                            _ => null
                        };

                        if (goal != null)
                        {
                            goal.IsComplete = isComplete;
                            goals.Add(goal);
                        }
                    }
                }
            }
        }
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager manager = new GoalManager();

            // Example goals
            manager.AddGoal(new SimpleGoal("Get Married", "Get Married", 1000));
            manager.AddGoal(new EternalGoal("Read Scriptures", "Read the scriptures daily", 100));
            manager.AddGoal(new ChecklistGoal("Temple Visits", "Visit the temple", 50, 10, 500));

            manager.DisplayGoals();
            manager.RecordEvent(0);  // Completing "Getting Married"
            manager.RecordEvent(1);  // Recording "Read Scriptures"
            manager.RecordEvent(2);  // Increment "Temple Visits"

            manager.DisplayGoals();

            // Save and load example
            string filename = "goals.txt";
            manager.Save(filename);
            manager.Load(filename);
        }
    }
}

}