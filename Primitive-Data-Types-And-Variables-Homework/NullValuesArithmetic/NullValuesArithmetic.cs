using System;


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

