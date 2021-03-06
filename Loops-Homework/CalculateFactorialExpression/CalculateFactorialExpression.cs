﻿using System;
using System.Numerics;

﻿//In combinatorics, the number of ways to choose k different members 
//out of a group of n different elements (also known as the number of combinations) 
//is calculated by the following formula: formula For example, there are 2598960 
//ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) 
//for given n and k (1 < k < n < 100). Try to use only two loops.

class CalculateFactorialExpression
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger factorialN = Factorial(n);
        BigInteger factorialK = Factorial(k);
        BigInteger factorialNMinusK = Factorial(n - k);

        BigInteger result = factorialN / (factorialK * factorialNMinusK);

        Console.WriteLine("{0}! / ({1}! * ({0} - {1})!) = {2}", n, k, result);
    }

    private static BigInteger Factorial(int n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }
}

