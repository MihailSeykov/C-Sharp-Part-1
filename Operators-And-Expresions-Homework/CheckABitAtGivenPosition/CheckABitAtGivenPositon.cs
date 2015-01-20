using System;



    class CheckABitAtGivenPositon
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            int integer = int.Parse(Console.ReadLine());
            Console.Write("Enter on which position to check bit: ");
            int position = int.Parse(Console.ReadLine());
            bool isOne = ((integer >> position) & 1) == 1;
            Console.WriteLine(isOne);
        }
    }

