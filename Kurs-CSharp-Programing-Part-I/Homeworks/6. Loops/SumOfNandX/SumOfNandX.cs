//6. Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SumOfNandX
{
    class SumOfNandX
    {
        static void Main()
        {
            Console.Write("Enter Number -> N: ");
            int numberN = int.Parse(Console.ReadLine());
            Console.Write("Enter Number -> X: ");
            int numberX = int.Parse(Console.ReadLine());

            BigInteger resultX = 1;
            BigInteger factorialN = 1;
            BigInteger s = 0;
            for (int i = 1; i <= numberN; i++)
            {
                factorialN *= i;                         // this give Number! (1! -> 2!-> 3! -> N!)
                resultX *= numberX;                     // this give number [X] on degree (X^2 -> X^3 -> X^N)
                s += (factorialN / resultX);           // divider part of equation + result [S]
            }
            Console.WriteLine("S = " + 1 + s);       // add [1] to equation and print result [S] 
        }
    }
}