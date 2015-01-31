using System;

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of 
//diamonds).

class PrintDeck
{
    static void Main()
    {
        byte length = 10;
        for (int i = 2; i <= length; i++)
        {
            Console.Write("{0} of spades, {0} of clubs, {0} of hearths, {0} of diamonds", i);
            Console.WriteLine("");
        }
        Console.WriteLine("J of spades, J of clubs, J of hearths, J of diamonds");
        Console.WriteLine("Q of spades, Q of clubs, Q of hearths, Q of diamonds");
        Console.WriteLine("K of spades, K of clubs, K of hearths, K of diamonds");
        Console.WriteLine("A of spades, A of clubs, A of hearths, A of diamonds");
    }
}

