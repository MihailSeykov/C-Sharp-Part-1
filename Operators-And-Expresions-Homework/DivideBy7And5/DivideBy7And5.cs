using System;

//Write a Boolean expression that checks for given integer if it can be divided (without remainder)
//by 7 and 5 at the same time.

class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Write an integer: ");
        int number = int.Parse(Console.ReadLine());
        bool divide =number % 7 == 0 && number % 5 == 0;
        Console.WriteLine(divide);
    }
}

