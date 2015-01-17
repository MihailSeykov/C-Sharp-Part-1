using System;

//Write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).

class PrintASCIITable
{
    static void Main()
    {
        for (int i = 0; i <= 255; i++)
        {
            System.Console.WriteLine("{0} = {1}", i, (char)i);
        }
    }
}

