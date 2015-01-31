using System;

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the 
//maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

class MinMaxSumAndAverage
{
    static void Main()
    {
        Console.Write("Enter how much integers you want to input: ");
        int length = int.Parse(Console.ReadLine());
        int sum = 0;
        int maxValue = 0;
        int minValue = 0;
        for (int i = 1; i <= length; i++)
        {
            Console.Write("Enter the {0} number: ", i);
            int number = int.Parse(Console.ReadLine());
            sum += number;
            if (number > maxValue)
            {
                maxValue = number;
            }
            if (number < minValue)
            {
                minValue = number;
            }
        }
        Console.WriteLine("The min is: " + minValue);
        Console.WriteLine("The max is: " + maxValue);
        Console.WriteLine("The sum is: " + sum);
        double average = sum / length;
        Console.WriteLine("The average is: " + average);
    }
}

