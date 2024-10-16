using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFracString());
        Console.WriteLine(f1.GetDecValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFracString());
        Console.WriteLine(f2.GetDecValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFracString());
        Console.WriteLine(f3.GetDecValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFracString());
        Console.WriteLine(f4.GetDecValue());

    }
}