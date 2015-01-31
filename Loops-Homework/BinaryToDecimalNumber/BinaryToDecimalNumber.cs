using System;

﻿//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binary = Console.ReadLine().Trim();

        Console.WriteLine(ConvertToDecimal(binary));
    }

    public static int ConvertToDecimal(string binary)
    {
        int decimalNumber = 0;

        for (int bit = binary.Length - 1, pow = 0; bit >= 0; bit--, pow++)
        {
            decimalNumber += int.Parse(binary[bit].ToString()) * (int)Math.Pow(2, pow);
        }
        return decimalNumber;
    }
}
