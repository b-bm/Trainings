// 5. Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoNumbers
{
    class GreaterOfTwoNumbers
    {
        static void Main()
        {
            Console.Write("Enter One Number: ");
            decimal firstNum = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            decimal secondNum = decimal.Parse(Console.ReadLine());

            decimal result = Math.Max(firstNum, secondNum);
            
            Console.WriteLine(result);
        }
    }
}
