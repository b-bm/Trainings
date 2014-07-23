//2. Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
//Напишете програма, която отпечатва на конзолата числата от 1 до N, които не се делят едновременно на 3 и 7. 
//Числото N да се чете от стандартния вход.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbersNotDivisibleBy3and7
{
    class PrintNumbersNotDivisibleBy3and7
    {
        static void Main()
        {
            Console.Write("Enter a number from 1 to N: ");
            int numberN = int.Parse(Console.ReadLine());

            Console.WriteLine("All numbers from [1] to [{0}], that are not divisible by 3 and 7 at the same time are: ", numberN);

            for (int i = 1; i <= numberN; i++)
            {
                if (!(i % (3 * 7) == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
