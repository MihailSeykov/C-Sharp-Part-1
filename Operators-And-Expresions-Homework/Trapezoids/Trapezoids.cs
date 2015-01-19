using System;

//Write an expression that calculates trapezoid's area by given sides a and b and height h.


class Trapezoids
{
    static void Main(string[] args)
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the height: ");
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) * h) / 2;
        Console.WriteLine("The are of the trapeziod is: {0}", area);
    }
}

