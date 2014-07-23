//8. Write a program that reads an integer number n from the console and prints all the numbers in the interval 
//[1..n], each on a single line.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbersInInterval
{
    class PrintNumbersInInterval
    {
        static void Main()
        {
            Console.Write("Enter some positive number please: ");
            uint number = uint.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("Enter number greater than 1");
            }
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
