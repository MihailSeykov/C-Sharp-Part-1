using System;

//Write a program that reads 3 real numbers from the console and prints their sum.

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());
        int sum = num1 + num2 + num3;
        Console.WriteLine("The sum of the numbers is: {0}", sum);
    }
}

