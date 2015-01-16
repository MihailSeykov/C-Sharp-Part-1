using System;

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

class RectanglesPerimeter
{
    static void Main()
    {
        Console.Write("Enter the width of the rectangle: ");
        float width = float.Parse(Console.ReadLine());
        Console.Write("Enter the height of the rectangle: ");
        float height = float.Parse(Console.ReadLine());
        float perimeter = (2 * (width + height));
        Console.WriteLine("The perimeter of the rectangle is: {0}", perimeter);
        float area = height * width;
        Console.WriteLine("The width  of the rectangle is: {0}", area);
    }
}

