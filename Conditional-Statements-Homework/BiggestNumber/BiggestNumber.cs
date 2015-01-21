using System;

//Write a program that finds the biggest of three numbers.

class BiggestNumber
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("The biggest number is: " + Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber));
    }
}

