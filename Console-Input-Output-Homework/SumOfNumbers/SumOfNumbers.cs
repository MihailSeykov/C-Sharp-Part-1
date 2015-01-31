using System;

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

    class SumOfNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} more numbers:", num);
            double i = 0;
            double sum = 0;
            for (i = 0; i < num; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                
                sum += numbers;
            }
            Console.WriteLine(sum);

        }
    }

