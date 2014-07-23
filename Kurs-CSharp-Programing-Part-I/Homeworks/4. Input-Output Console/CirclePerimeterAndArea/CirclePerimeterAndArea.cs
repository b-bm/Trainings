// 2. Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Enter Circle's radius: ");
            double radius = double.Parse(Console.ReadLine());

            double area = (Math.PI * radius * radius);
            double perimeter = (Math.PI * radius) * 2;

            Console.WriteLine("The Cirkle's Area is: {0}", area);
            Console.WriteLine("The Circle's Perimeter is: {0}", perimeter);
        }
    }
}
