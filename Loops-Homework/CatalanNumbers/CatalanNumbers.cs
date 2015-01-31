using System;
using System.Numerics;

﻿//Write a program to calculate the nth Catalan number by given n (1 < n < 100).

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger result = (Factorial(2 * n)) / (Factorial(n + 1) * Factorial(n));

        Console.WriteLine(result);
    }
    private static BigInteger Factorial(int n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }
}

