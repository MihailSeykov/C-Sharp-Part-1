using System;

//Write a program that gets two numbers from the console and prints the greater of them.

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the first number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("The bigger number is: " + Math.Max(num1, num2));

    }
}

