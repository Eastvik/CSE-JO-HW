using System;
using System.Threading;

public abstract class Activity
{
    public string Name { get; }
    public string Description { get; }
    protected int Duration { get; private set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"\nStarting {Name} Activity");
        Console.WriteLine(Description);
        Console.Write("Enter the duration of the activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("\nGood job!");
        Console.WriteLine($"You have completed the {Name} Activity.");
        Console.WriteLine($"Duration: {Duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write("\r|/-\\"[i % 4]);
            Thread.Sleep(250);
        }
        Console.Write("\r ");
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} seconds...");
            Thread.Sleep(1000);
        }
        Console.Write("\r");
    }

    public abstract void PerformActivity();
}
