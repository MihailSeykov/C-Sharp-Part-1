﻿using System;

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0
//and solves it (prints its real roots).

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        double d = (b * b) - 4 * (a * c);
        if (d < 0)
        {
            Console.WriteLine("No real roots!");
        }
        if (d == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Only one root: x = {0}", x);
        }
        double x1 = (-b - Math.Sqrt(d)) / (2 * a);
        double x2 = (-b + Math.Sqrt(d)) / (2 * a);
        Console.WriteLine("The roots are: x1 = {0}; x2 = {1}", x1, x2);
    }
}

