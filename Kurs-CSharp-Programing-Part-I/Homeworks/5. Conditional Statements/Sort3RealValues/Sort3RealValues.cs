//4. Sort 3 real values in descending order using nested if statements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort3RealValues
{
    class Sort3RealValues
    {
        static void Main()
        {
            Console.WriteLine("Enter Three numbers");

            Console.Write("Enter first: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter second: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter third: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            double swapValue = 0;

            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    swapValue = firstNumber;
                    firstNumber = thirdNumber;
                    thirdNumber = swapValue;
                }

                if (firstNumber > secondNumber)
                {
                    swapValue = firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = swapValue;
                }
            }
            else if (secondNumber > thirdNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    swapValue = firstNumber;
                    firstNumber = thirdNumber;
                    thirdNumber = swapValue;
                }

                if (secondNumber > thirdNumber)
                {
                    swapValue = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = swapValue;
                }
            }

            Console.WriteLine("\nNumbers in descending order: {0} < {1} < {2}\n", firstNumber, secondNumber, thirdNumber);
        }
    }
}
