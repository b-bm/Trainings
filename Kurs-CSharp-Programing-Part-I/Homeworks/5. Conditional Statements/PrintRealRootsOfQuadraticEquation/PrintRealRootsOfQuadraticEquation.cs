//6. Write a program that enters the coefficients a, b and c of a quadratic equation
//a*x2 + b*x + c = 0 and calculates and prints its real roots. 
//Note that quadratic equations may have 0, 1 or 2 real roots.
//Напишете програма, която при въвеждане на коефициентите (a, b и c) на квадратно уравнение: ax2+bx+c, 
//изчислява и извежда неговите реални корени (ако има такива). 
//Квадратните уравнения могат да имат 0, 1 или 2 реални корена.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintRealRootsOfQuadraticEquation
{
    class PrintRealRootsOfQuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Enter \"a\", \"b\" and \"c\" of a quadratic equation [a*x2 + b*x + c = 0]");

            Console.Write("\nEnter \"a\": ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter \"b\": ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter \"c\": ");
            double c = double.Parse(Console.ReadLine());

            double x1, x2, discriminant;

            if (a == 0)
            {
                Console.WriteLine("This is not quadratic equation");
            }
            else  // D = b2 - 4ac -> D = b*b - (4*a*c)
            {
                discriminant = b * b - (4 * a * c);
                if (discriminant < 0)
                {
                    Console.WriteLine("Quadratic equation have not a real roots, discriminant is {0} ", discriminant);
                }
                else if (discriminant == 0)
                {
                    x1 = b / 2 * a;
                    Console.WriteLine("Discriminant is 0 and root \"x1\" is equal to \"x2\": {0}", x1);
                }
                else if (discriminant > 0)
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                    x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
                    
                    Console.WriteLine("Root \"x1\" is {0}", x1);
                    Console.WriteLine("Root \"x2\" is {0}", x2);
                }
            }
        }
    }
}
