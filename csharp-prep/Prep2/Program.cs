using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? >%");
        //I found out that ctrl f2 also changes printed instances not just variable names.
        string gradeValue = Console.ReadLine();
        int gPercent = int.Parse(gradeValue);
        
        //define grade letter to replace later
        string letter ="";

        if (gPercent >= 90)
        {
            letter = "A";
        }
        else if (gPercent >= 80)
        {
            letter = "B";
        }
        else if (gPercent >= 70)
        {
            letter = "C";
        }
        else if (gPercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        //Print statement, this said "letter letter" after changing all occurances of the variable 'grade' to 'letter'
        Console.WriteLine($"Your grade letter is {letter}");

        if (gPercent >= 70)
        {
            Console.WriteLine("Great job, you passed!");
        }
        else
        {
            Console.WriteLine("Please contact your academic advisor, resources will be provided to aid you in the future");
        }
        

    }
}