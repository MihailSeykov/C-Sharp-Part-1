using System;

//Write an expression that checks if given integer is odd or even.

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter a number:");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("The number is even!");
        }
        else
        {
            Console.WriteLine("The number is odd!");
        }
    }
}

