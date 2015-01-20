using System;

//Write an expression that extracts from given integer n the value of given bit at index p.

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        Console.Write("Enter on which position to check bit: ");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine((integer >> position) & 1);
    }
}

