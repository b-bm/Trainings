//9. In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
// ( formula = http://en.wikipedia.org/wiki/Catalan_number  => C(n) = (2*n)!/(n+1)!*n!, for n >= 0
//Write a program to calculate the Nth Catalan number by given N.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace NthCatalianNumber
{
    class NthCatalianNumber
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            uint n = uint.Parse(Console.ReadLine());

            Console.WriteLine("\nC({0}) = {1}\n", n, Factorial(2 * n) / Factorial(n + 1) * Factorial(n));
        }

        static BigInteger Factorial(uint n)  // Calculate factorial
        {
            if (n < 1) return 1;

            return n * Factorial(n - 1);
        }
        // Ver.2:
        //static void Main()
        //{
        //    Console.Write("Enter N: ");
        //    BigInteger n = BigInteger.Parse(Console.ReadLine());
            
        //    BigInteger catalanNumber = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));
        //    Console.WriteLine("Catalan Number = {0}", catalanNumber);
        //}
        //static BigInteger Factorial(BigInteger n)  // Calculate factorial
        //{
        //    BigInteger nFactorial = 1;
        //    for (BigInteger i = 1; i <= n; i++)
        //    {
        //        nFactorial = nFactorial * i;
        //    }
        //    return nFactorial;
        //}
    }
}