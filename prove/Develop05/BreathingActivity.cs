using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void PerformActivity()
    {
        StartActivity();
        int timeRemaining = Duration;
        while (timeRemaining > 0)
        {
            Console.WriteLine("\nBreathe in...");
            Countdown(3);
            timeRemaining -= 3;
            if (timeRemaining <= 0) break;

            Console.WriteLine("Breathe out...");
            Countdown(3);
            timeRemaining -= 3;
        }
        EndActivity();
    }
}
