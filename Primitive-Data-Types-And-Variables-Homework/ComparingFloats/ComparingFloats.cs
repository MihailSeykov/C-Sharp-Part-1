using System;


    class ComparingFloats
    {
        static void Main(string[] args)
        {
           
            
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());
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

