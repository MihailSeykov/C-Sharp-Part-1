using System;
using System.Text;

//Write a program that prints an isosceles triangle of 9 copyright symbols ©.

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        char symbol = '\u00A9';

        Console.WriteLine("   " + symbol);
        Console.WriteLine(" ");
        Console.WriteLine("  " + symbol + " " + symbol);
        Console.WriteLine(" ");
        Console.WriteLine(" " + symbol + "   " + symbol);
        Console.WriteLine(" ");
        Console.WriteLine(symbol + " " + symbol + " " + symbol + " " + symbol);

    }
}

