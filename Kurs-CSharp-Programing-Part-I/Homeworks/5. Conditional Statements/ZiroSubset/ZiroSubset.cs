//9. We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.
//Example: 3, -2, 1, 1, 8  1+1-2=0.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiroSubset
{
    class ZiroSubset
    {
        static void Main()
        {
            Console.WriteLine("Please enter 5 integer numbers: ");
            Console.Write("\na= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d= ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("e= ");
            int e = int.Parse(Console.ReadLine());

            int count = 0;
            int sum = 0;

            for (int i = 1; i < 32; i++)
            {
                if ((i & 1) == 1)
                {
                    sum += a;
                }
                if (((i >> 1) & 1) == 1)
                {
                    sum += b;
                }
                if (((i >> 2) & 1) == 1)
                {
                    sum += c;
                }
                if (((i >> 3) & 1) == 1)
                {
                    sum += d;
                }
                if (((i >> 4) & 1) == 1)
                {
                    sum += e;
                }
                if (sum == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("The sum of {0} subset is 0", count);
        }
    }
}