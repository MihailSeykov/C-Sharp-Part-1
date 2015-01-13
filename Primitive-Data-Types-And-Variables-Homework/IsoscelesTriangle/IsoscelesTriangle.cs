using System;
using System.Text;


class IsoscelesTriangle
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        char symbol = '\u00A9';

        Console.WriteLine("   " + symbol);
        Console.WriteLine("  " + symbol + " " + symbol);
        Console.WriteLine(" " + symbol + "   " + symbol);
        Console.WriteLine(symbol + " " + symbol + " " + symbol + " " + symbol);

    }
}

