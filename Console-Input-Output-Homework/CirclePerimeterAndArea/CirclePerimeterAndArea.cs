using System;

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with
//2 digits after the decimal point.

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Enter the radius of a circle: ");
            double r = double.Parse(Console.ReadLine());
            double perimeter = (2 * 3.14) * r;
            Console.WriteLine("The perimeter of the circle is: " + string.Format("{0:0.00}", perimeter));
            double area = 3.14 * (r * r);
            Console.WriteLine("The are of the circle is: " + string.Format("{0:0.00}", area));
        }
    }

