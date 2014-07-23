//7. Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TreadWithFibonacci
{
    class TreadWithFibonacci
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            ulong numberN = ulong.Parse(Console.ReadLine());

            BigInteger firstMember = 1;
            BigInteger secondMember = 0;
            BigInteger thirdMember = 0;
            BigInteger sum = 0;

            for (BigInteger i = 0; i <= numberN; i++)
            {
                thirdMember = firstMember + secondMember;
                firstMember = secondMember;
                secondMember = thirdMember;
                Console.WriteLine(i + ": " + thirdMember);
                sum += thirdMember;  // sum = sum + thirdMember 
            }
            Console.WriteLine("The sum of first [N] members is: {0}", sum);

            // Var.2:
            //Console.Write("Enter N: ");
            //ulong numberN = ulong.Parse(Console.ReadLine());

            //ulong firstMember = 1;
            //ulong secondMember = 0;
            //ulong thirdMember = 0;
            //ulong sum = 0;

            //for (ulong i = 0; i <= numberN; i++)
            //{
            //    thirdMember = firstMember + secondMember;
            //    firstMember = secondMember;
            //    secondMember = thirdMember;
            //    Console.WriteLine(i + ": " + thirdMember);
            //    sum += thirdMember;  // sum = sum + thirdMember 
            //}
            //Console.WriteLine("The sum of first [N] members is: {0}", sum);
        }
    }
}