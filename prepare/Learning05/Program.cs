using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment a1 = new Assignment("Albert Einstein", "Quantum Physics");
        Console.WriteLine(a1.GetSummary());

        // Now create the derived class assignments
        MathAssignment a2 = new MathAssignment("Stephen Hawking", "Basic Addition", "8.3", "9-15");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Bill Gates", "Coding in C", "Basic OS");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}