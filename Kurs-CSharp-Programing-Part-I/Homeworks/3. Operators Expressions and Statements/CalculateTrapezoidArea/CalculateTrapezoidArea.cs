//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class CalculateTrapezoidArea
{
    static void Main()
    {
        int sideA = 13;
        int sideB = 7;
        int height = 15;
        int area = ((sideA + sideB) / 2) * height;
        Console.WriteLine("The trapezoid's area si = {0}", area);

        //Вариянт 2:

        //Console.Write("Enter side A: ");
        //string value1 = Console.ReadLine();
        //double sideA = double.Parse(value1);

        //Console.Write("Enter side B: ");
        //string value2 = Console.ReadLine();
        //double sideB = double.Parse(value2);

        //Console.Write("Enter height: ");
        //string value3 = Console.ReadLine();
        //double height = double.Parse(value3);

        //double area = ((sideA + sideB) / 2) * height;
        //Console.WriteLine("Trapezoid's area is : {0}", area);
    }
}