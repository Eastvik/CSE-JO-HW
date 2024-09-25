using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string user = PromptUserName();
    
        int userNumber = PromptUserNumber();
       int squaredNumber = SquareNumber(userNumber);

        DisplayResult(user, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string PromptUserName()
    {
        Console.Write("What is your username?:>");
        string nameUser = Console.ReadLine();

        return nameUser;
    }
//Kept accidentally putting void on int and string functions, still getting used to C#
    static int PromptUserNumber()
    {
        Console.Write("Please submit a number.:> ");
        int numbUser = int.Parse(Console.ReadLine());

        return numbUser;
    }
    static int SquareNumber(int userNumber)
    {   //I miss the ** operator for exponents
        int square = userNumber * userNumber;

        return square;
    }

    static  void DisplayResult(string user, int squaredNumber)
    {
        Console.Write($"{user} the square of your number is {squaredNumber}.");

    }

}