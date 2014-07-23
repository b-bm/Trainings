//9. Write a program to print the first 100 members of the sequence of Fibonacci: 
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace First100MembersOfFibonacci
{
    class First100MembersOfFibonacci
    {
        static void Main()
        {
            BigInteger firstMember = 0;
            BigInteger secondMember = 1;

            Console.WriteLine("Now we will print first 100 members of Fibonacci sequence: ");

            for (int members = 0; members < 100; members++)
            {
                Console.WriteLine(firstMember);
                BigInteger sum = firstMember + secondMember;

                firstMember = secondMember;
                secondMember = sum;
            }
        }
    }
}
