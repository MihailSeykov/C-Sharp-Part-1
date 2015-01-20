using System;

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

class ExtractBit3
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        Console.WriteLine((integer >> 3) & 1);
    }
}

