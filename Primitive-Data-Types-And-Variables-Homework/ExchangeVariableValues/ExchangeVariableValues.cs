using System;

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("The value of a before the exchange is = " + a);
        Console.WriteLine("The value of b before the exchange is = " + b);
        b = b - a;
        a = a + a;
        Console.WriteLine("Tne value of a after the exchange is = " + a);
        Console.WriteLine("The value of b after the exchange is = " + b);
    }
}
