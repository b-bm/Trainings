//7. Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
// Напишете програма, която прочита едно цяло число n от конзолата. 
//След това прочита още n на брой числа от конзолата и отпечатва тяхната сума.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSumOfEnNumbers
{
    class TheSumOfEnNumbers
    {
        static void Main()
        {
            Console.Write("Enter number of numbers to calculate: ");
            int numberCount = int.Parse(Console.ReadLine());

            long sumOfNumbers = 0;

            for (int i = 0; i < numberCount; i++)
            {
                Console.Write("{0}: ", i + 1);
                
                int number = int.Parse(Console.ReadLine());
                sumOfNumbers = sumOfNumbers + number;
            }
            Console.WriteLine("\nThe sum of all numbers is: {0}\n", sumOfNumbers);
        }
    }
}