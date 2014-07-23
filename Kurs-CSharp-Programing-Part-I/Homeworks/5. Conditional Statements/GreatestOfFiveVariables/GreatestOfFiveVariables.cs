// 7. Write a program that finds the greatest of given 5 variables.
//Напишете програма, която намира най-голямото по стойност число измежду дадени 5 числа.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestOfFiveVariables
{
    class GreatestOfFiveVariables
    {
        static void Main()
        {
            Console.WriteLine("Enter Five variables");

            Console.Write("\nEnter first: ");
            double firstVar = double.Parse(Console.ReadLine());

            Console.Write("Enter second: ");
            double secondVar = double.Parse(Console.ReadLine());

            Console.Write("Enter third: ");
            double thirdVar = double.Parse(Console.ReadLine());

            Console.Write("Enter fourth: ");
            double fourthVar = double.Parse(Console.ReadLine());

            Console.Write("Enter fifth: ");
            double fifthVar = double.Parse(Console.ReadLine());
            
            double biggestVar = firstVar;
            
            if (biggestVar < secondVar)
            {
                biggestVar = secondVar;
            }
            if (biggestVar < thirdVar)
            {
                biggestVar = thirdVar;
            }
            if (biggestVar < fourthVar)
            {
                biggestVar = fourthVar;
            }
            if (biggestVar < fifthVar)
            {
                biggestVar = fifthVar;
            }
            Console.WriteLine("The greatest of this 5 variables is: {0}", biggestVar);
        }
    }
}
