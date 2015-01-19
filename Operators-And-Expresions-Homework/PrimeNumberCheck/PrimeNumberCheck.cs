using System;

//Write an expression that checks if given positive integer number n (n = 100) is prime 
//(i.e. it is divisible without remainder only to itself and 1).


class Program
{
    static void Main()
    {
        Console.Write("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        if (number == 0 || number == 1)
        {
            Console.WriteLine(number + " Is not a primer number!");
        }
        else
        {
            for (int a = 2; a<= number / 2; a++)
            {
                if (number % a == 0)
                {
                    Console.WriteLine(number + " Is not a prime number!");
                    return;
                }
            }
            Console.WriteLine(number + " Is a prime number!");
        }
    }
}

