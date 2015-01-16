using System;

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

class GravitationOnTheMoon
{
    static void Main(string[] args)
    {
        Console.Write("Enter a weight: ");
        double weight = double.Parse(Console.ReadLine());
        double moon = 0.17;
        double result = moon * weight;
        Console.WriteLine("This weight on the moon is: {0} ", result);
    }
}

