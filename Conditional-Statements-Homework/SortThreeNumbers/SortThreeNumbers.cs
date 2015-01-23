using System;

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.

class SortThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", firstNumber,secondNumber,thirdNumber);
            }
            else if (thirdNumber > secondNumber)
            {
                Console.WriteLine("{0} {1} {2}", firstNumber,thirdNumber,secondNumber);
            }
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", secondNumber,firstNumber,thirdNumber);
            }
            else if (thirdNumber > firstNumber)
            {
                Console.WriteLine("{0} {1} {2}", secondNumber,thirdNumber,firstNumber);
            }
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("{0} {1} {2}",thirdNumber,firstNumber,secondNumber);
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine("{0} {1} {2}",thirdNumber,secondNumber,firstNumber);
            }
        }
    }
}

