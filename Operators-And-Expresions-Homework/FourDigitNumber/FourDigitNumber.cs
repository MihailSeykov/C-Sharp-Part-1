using System;

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter 4 digit number: ");
        int number = int.Parse(Console.ReadLine());
        int a = number % 10;
        int b = (number / 10) % 10;
        int c = (number / 100) % 10;
        int d = (number / 1000) % 10; 
        Console.Write("The sum of the digits is: ");
        Console.WriteLine(a + b + c + d);
        Console.WriteLine("The numbers in reversed order are: {0}{1}{2}{3}", a, b, c, d);
        Console.WriteLine("The last digit in the first position: {0}{1}{2}{3}", a, d, c, b);
        Console.WriteLine("Second and third digit exchanged: {0}{1}{2}{3}", d, b, c, a);        

    }
}

