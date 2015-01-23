using System;

//Write an expression that checks for given integer if its third digit from right-to-left is 7.


class ThirdDigit
{
    static void Main()
    {
        Console.Write("Write an integer: ");
        int number = int.Parse(Console.ReadLine());
        bool thirdDigit = ((number / 100) % 10 == 7);
        Console.WriteLine(thirdDigit);

    }
}

