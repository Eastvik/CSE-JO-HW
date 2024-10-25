using System;

class Program
{
static void Main(string[] args)
{
    // Previous code for Assignment and MathAssignment
    Assignment simpleAssignment = new Assignment("Samuel Bennett", "Multiplication");
    Console.WriteLine(simpleAssignment.GetSummary());

    MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
    Console.WriteLine(mathAssignment.GetSummary());
    Console.WriteLine(mathAssignment.GetHomeworkList());

    // Create a WritingAssignment object
    WritingAssignment writingAssignment = new WritingAssignment("Mary Johnson", "Ancient History", "The Rise of the Roman Empire");

    
    Console.WriteLine(writingAssignment.GetSummary());
    Console.WriteLine(writingAssignment.GetWritingInformation());
}

}