﻿//5. Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
// N = 5;
// K = 10;
// N! * K! => 1.2.3.4.5 * 1.2.3.4.5.6.7.8.9.10
// (K-N)! => 5! => 1.2.3.4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FactorialExpression
{
    class FactorialExpression
    {
        static void Main()
        {
            Console.WriteLine("You should to enter two numbers [N and K] and [K > N > 1]");
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            for (int i = k - n + 1; i <= k; i++)
            {
                factorial *= i;

                if (i == k)
                {
                    i = 2;

                    while (i <= n)
                    {
                        factorial *= i;
                        i++;
                    }

                    break;
                }
            }

            Console.WriteLine("\nResult of this {0}!*{1}!/({1}-{0})! = {2}\n", n, k, factorial);
        }
    }
}