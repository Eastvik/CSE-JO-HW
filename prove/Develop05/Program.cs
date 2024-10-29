using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var activities = new Dictionary<int, Activity>
        {
            { 1, new BreathingActivity() },
            { 2, new ReflectionActivity() },
            { 3, new ListingActivity() }
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity: ");

            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice.");
                continue;
            }

            if (choice == 4)
            {
                Console.WriteLine("Thank you for using the program. Goodbye!");
                break;
            }

            activities[choice].PerformActivity();
        }
    }
}
