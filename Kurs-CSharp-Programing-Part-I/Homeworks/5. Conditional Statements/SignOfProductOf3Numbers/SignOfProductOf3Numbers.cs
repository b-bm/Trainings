//2. Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it.
//Use a sequence of if statements.
//Напишете програма, която показва знака (+ или -) от произведението на три реални числа, без да го пресмята. 
//Използвайте последователност от if оператори.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfProductOf3Numbers
{
    class SignOfProductOf3Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter 3 Numbers");

            Console.Write("Enter first: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter third: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber * secondNumber * thirdNumber < 0)
            {
                Console.WriteLine("{0} * {1} * {2} the result is with NEGATIVE sign (-)", firstNumber, secondNumber, thirdNumber);
            }
            else if (firstNumber * secondNumber * thirdNumber == 0)
            {
                Console.WriteLine("{0} * {1} * {2} the result is ZIRO", firstNumber, secondNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("{0} * {1} * {2} the result is with POSITIVE sign (+)", firstNumber, secondNumber, thirdNumber);
            }
        }
    }
}
