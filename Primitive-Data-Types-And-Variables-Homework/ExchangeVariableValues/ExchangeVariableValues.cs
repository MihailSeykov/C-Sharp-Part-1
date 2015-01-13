using System;


    class ExchangeVariableValues
    {
        static void Main(string[] args)
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
