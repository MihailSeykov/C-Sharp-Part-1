using System;

//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            if (0 <= a && a <= 500)
            {
                Console.Write("Enter the second number: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter the third number: ");
                double c = double.Parse(Console.ReadLine());
                Console.Write("{0:X}", a);
                string binary = Convert.ToString(a, 2);
                string twoDigitsPrecision = string.Format("{0:0.00}", b);
                Console.Write("  |" + binary + "|  ");
                Console.Write(twoDigitsPrecision);
                string threeDigitsPrecision = string.Format("{0:0.000}", c);
                Console.WriteLine("|" + threeDigitsPrecision + " |");
            }
            Console.WriteLine("Incorrect input number one!");
        }
    }
}
