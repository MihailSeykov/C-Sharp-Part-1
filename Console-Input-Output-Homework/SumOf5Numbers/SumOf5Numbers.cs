using System;

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

class Program
{
    static void Main()
    {
        Console.Write("Enter five numbers: ");
        string[] fiveNumbers = Console.ReadLine().Split();
        double firstNumber = double.Parse(fiveNumbers[0] + " ");
        double secondNumber = double.Parse(fiveNumbers[1] + " ");
        double thirdNumber = double.Parse(fiveNumbers[2] + " ");
        double fourthNumber = double.Parse(fiveNumbers[3] + " ");
        double fifthNumber = double.Parse(fiveNumbers[4] + " ");
        double sum = firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber;
        Console.WriteLine("The sum of the numbers is: {0}", sum);
    }
}

