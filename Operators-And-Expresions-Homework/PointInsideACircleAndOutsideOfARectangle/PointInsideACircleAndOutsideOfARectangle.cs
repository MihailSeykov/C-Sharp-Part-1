using System;

//Write an expression that checks for given point (x, y) if it is within the circle
//K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        double r = 1.5;
        bool insideCircle = ((((x * x) - (2 * x) + 1) + ((y * y) - (2 * y) + 1)) <= (r * r));
        bool insideRectangle = ((x >= -1 && x <= 5) && (y >= -1 && y <= 1));
        if (insideCircle == true && insideRectangle == false)
        {
            Console.WriteLine("Yes!");
        }
        else
        {
            Console.WriteLine("No!");
        }
    }
}

