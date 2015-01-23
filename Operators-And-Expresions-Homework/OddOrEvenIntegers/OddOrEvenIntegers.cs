using System;

//Write an expression that checks if given integer is odd or even.

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter a number:");
        int num = int.Parse(Console.ReadLine());
        bool isOdd = !(num % 2 == 0);
        Console.WriteLine(isOdd);
      
    }
}

