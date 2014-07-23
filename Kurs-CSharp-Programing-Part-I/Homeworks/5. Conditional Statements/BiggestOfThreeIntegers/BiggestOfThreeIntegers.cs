//3. Write a program that finds the biggest of three integers using nested if statements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOfThreeIntegers
{
    class BiggestOfThreeIntegers
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

            if (firstNumber > secondNumber)
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine("The Biggest number is: {0} first number", firstNumber);
                }
                else if (thirdNumber > secondNumber)
                {
                    if (thirdNumber > firstNumber)
                    {
                        Console.WriteLine("The Biggest number is: {0} third number", thirdNumber);
                    }
                    else
                    {
                        Console.WriteLine("The Biggest number is: {0} first number", firstNumber);
                    }
                }
            }
            else if (secondNumber > thirdNumber)
            {
                Console.WriteLine("The Biggest number is: {0} second number", secondNumber);
            }
            else
            {
                Console.WriteLine("The Biggest number is: {0} third number", thirdNumber);
            }
        }
    }
}
