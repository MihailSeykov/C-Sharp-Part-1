using System;

//Write a program that reads an integer number n from the console and prints all the numbers
//in the interval [1..n], each on a single line.

class NumbersFromOneToN
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        int i = (number - number);
        while (i < number)
        {
            i++;
            Console.WriteLine(i);
        }
    }
}

