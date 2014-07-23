//1. Write a program that prints all the numbers from 1 to N.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbersFromOneToN
{
    class PrintNumbersFromOneToN
    {
        static void Main()
        {
            Console.Write("Enter one number in range 1 to N: ");
            ulong numberN = ulong.Parse(Console.ReadLine());

            for (ulong i = 1; i <= numberN; i++ )
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}