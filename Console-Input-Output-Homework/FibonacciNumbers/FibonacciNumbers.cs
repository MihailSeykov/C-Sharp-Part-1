using System;

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence.


class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int num1 = 0;
        int num2 = 1;
        int sum = 1;
        int i = 2;
        Console.WriteLine(num1);
        for (sum = 1; i <= number; i++)
        {
            sum = num1 + num2;
            num1 = num2;
            num2 = sum;
            Console.WriteLine(num2);
        }
    }
}

