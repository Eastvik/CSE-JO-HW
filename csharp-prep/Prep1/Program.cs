using System;
//Removed Hello World
//Why does James Bond use his real name? 
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your given name? >");
        string first = Console.ReadLine();

        Console.Write("What is your surname? >");
        string last = Console.ReadLine();
        Console.WriteLine($"Your nmae is {last}, {first} {last}.");
    }
}