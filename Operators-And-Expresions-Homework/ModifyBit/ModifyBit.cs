 using System;

﻿//We are given an integer number n,
//a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) 
//that modifies n to hold the value v at the position p 
//from the binary representation of n while preserving all other 
//bits in n.

class ModifyBit
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        Console.Write("Enter bit value: ");
        int bitValuev = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(integer, 2).PadLeft(32, '0'));
        int newValue;
        int bitAtRight;
        if (bitValuev == 1)
        {
            bitAtRight = 1 << position;
            newValue = integer | bitAtRight;
            Console.WriteLine(Convert.ToString(newValue, 2).PadLeft(32, '0'));
            Console.WriteLine("Result = " + newValue);
        }
        else if (bitValuev == 0)
        {
            bitAtRight = ~(1 << position);
            newValue = integer & bitAtRight;
            Console.WriteLine(Convert.ToString(newValue, 2).PadLeft(32, '0'));
            Console.WriteLine("Result = " + newValue);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}