// 10. Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAccuracyOf
{
    class SumAccuracyOf
    {
        static void Main()
        {
            decimal expression = 1;
            Console.Write("Enter value for denominator: ");
            decimal value = decimal.Parse(Console.ReadLine());

            Console.Write("1 ");
            for (int denominator = 2; denominator <= value; denominator++)
            {
                if (denominator % 2 == 0)
                {
                    Console.Write("+ 1/{0} ", denominator);
                    expression = expression + 1m / denominator;
                }
                else
                {
                    Console.Write("- 1/{0} ", denominator);
                    expression = expression - 1m / denominator;
                }
            }

            Console.Write("= {0:F3}\n\n", expression);
        }
    }
}
