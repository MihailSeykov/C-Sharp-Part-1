using System;

//Write a program that finds the biggest of three numbers.

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        double biggestNumber = double.MinValue;
        double currentNumber;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Enter the {0} number: ", i);
            currentNumber = double.Parse(Console.ReadLine());
            if (currentNumber > biggestNumber)
            {
                biggestNumber = currentNumber;
            }
        }
        Console.WriteLine("The biggest number is: {0}", biggestNumber);

    }
}

