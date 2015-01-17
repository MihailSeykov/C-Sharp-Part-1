using System;

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

class ComparingFloats
{
    static void Main(string[] args)
    {


        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        bool equal = Math.Abs(num1 - num2) < 0.000001;
        Console.WriteLine(equal);
    }
}

