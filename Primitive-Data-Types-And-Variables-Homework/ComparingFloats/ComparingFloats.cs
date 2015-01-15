using System;


class ComparingFloats
{
    static void Main(string[] args)
    {


        Console.Write("Enter the first number: ");
        double num1 = 0;
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = 0;
        num2 = Convert.ToDouble(Console.ReadLine());
        double eps = 0.000001;
        if ((num1 - num2) < eps)
        {
            Console.WriteLine("True");
        }
        if ((num1 - num2) >= eps)
        {
            Console.WriteLine("False");
        }

    }
}

