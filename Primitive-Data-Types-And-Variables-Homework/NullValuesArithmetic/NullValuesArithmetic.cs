using System;

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

class NullValuesArithmetic
{
    static void Main(string[] args)
    {
        int nullvalue1 = Convert.ToInt32(null);
        double nullvalue2 = Convert.ToInt32(null);

        Console.WriteLine(nullvalue1 + 3);
        Console.WriteLine(nullvalue2 + 2.5);
    }
}

