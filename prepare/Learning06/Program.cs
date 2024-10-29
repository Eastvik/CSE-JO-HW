using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create individual shape instances and test their methods
        Square square = new Square("Red", 4);
        Console.WriteLine($"Square - Color: {square.GetColor()}, Area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Blue", 5, 3);
        Console.WriteLine($"Rectangle - Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");

        Circle circle = new Circle("Green", 2.5);
        Console.WriteLine($"Circle - Color: {circle.GetColor()}, Area: {circle.GetArea()}");

        // Create a list of shapes
        List<Shape> shapes = new List<Shape> { square, rectangle, circle };

        // Iterate through the list and display color and area
        Console.WriteLine("\nShape List:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}
