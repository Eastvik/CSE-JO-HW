using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private static readonly List<string> Prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> Questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private static readonly Random Random = new();

    public ReflectionActivity()
        : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.") { }

    public override void PerformActivity()
    {
        StartActivity();
        Console.WriteLine("\n" + Prompts[Random.Next(Prompts.Count)]);
        int timeRemaining = Duration;
        while (timeRemaining > 0)
        {
            Console.WriteLine(Questions[Random.Next(Questions.Count)]);
            ShowSpinner(5);
            timeRemaining -= 5;
        }
        EndActivity();
    }
}
