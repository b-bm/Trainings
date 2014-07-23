// Write a program that reads two positive integer numbers and prints how many numbers p exist between 
//them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintsHowManyNumbersExistV2
{
    class PrintsHowManyNumbersExistV2
    {
        static void Main()
        {
            Console.Write("Enter One positive Number A: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Second positive Number B: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secondNumber)
            {
                Console.WriteLine("No numbers between \"A\" and \"B\" that are divisible by 5.\nThis Two Numbers are Equal");
            }
            //Console.WriteLine("Enter NEW Two Numbers:");
            //int firstNumber = int.Parse(Console.ReadLine());
            //int secondNumber = int.Parse(Console.ReadLine());

            else if (firstNumber > secondNumber)
            {
                Console.WriteLine("Enter a valid numbers-> \"A\" must be SMALLER than \"B\" !");
            }
            
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0)
                Console.Write(i + (i < secondNumber ? ", " : ""));
            }
            Console.WriteLine("\n");
        }
    }
}
