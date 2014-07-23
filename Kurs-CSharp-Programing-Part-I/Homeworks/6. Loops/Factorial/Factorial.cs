//4. Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Factorial
    {
        static void Main()
        {
            Console.WriteLine("You should to enter two numbers [N and K] and [N > K > 1]");

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            for (int i = 0; i < (n - k); i++)
            {
                factorial = factorial * (n - i);  
            }
            Console.WriteLine("Result is --> {0}!/{1}! = {2}", n, k, factorial);
        }
    }
}