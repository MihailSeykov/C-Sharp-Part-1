using System;

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

class PointInACircle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        bool insideCircle =(Math.Sqrt((x * x) + (y * y)) <= 2.0);
        Console.WriteLine(insideCircle);
    }
}

