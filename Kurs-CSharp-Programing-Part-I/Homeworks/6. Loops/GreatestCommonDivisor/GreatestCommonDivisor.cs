//8. Write a program that calculates the greatest common divisor (GCD) of given two numbers.
//Use the Euclidean algorithm (find it in Internet).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main()
        {
            Console.WriteLine("Enter Two Numbers:");
            Console.Write("Enter First: ");
            uint a = uint.Parse(Console.ReadLine());
            Console.Write("Enter Second: ");
            uint b = uint.Parse(Console.ReadLine());

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            if (a == 0)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
