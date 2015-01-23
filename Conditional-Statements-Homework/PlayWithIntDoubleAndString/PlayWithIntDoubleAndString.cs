using System;

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.Write("Please choose a type(1 for integer, 2 for double, 3 for string): ");
        byte number = byte.Parse(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.Write("Please enter an integer: ");
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine(integer + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleNumber + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string text = Console.ReadLine();
                Console.WriteLine("{0}*", text);
                break;
            default:
                Console.WriteLine("Not valid type!!!");
                break;
        }
    }
}

