// 1. Write an if statement that examines two integer variables
//and exchanges their values if the first one is greater thanthe second one.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumberExchanges
{
    class GreaterNumberExchanges
    {
        static void Main()
        {
            Console.WriteLine("Enter Two integers A and B ");
            
            Console.Write("Enter first A: ");
            int integerA = int.Parse(Console.ReadLine());

            Console.Write("Enter second B: ");
            int integerB = int.Parse(Console.ReadLine());
            int integerC = 0;

            if (integerA > integerB)
            {
                int smallerA = integerB + integerC;
                int greaterB = integerA;

                Console.WriteLine("We changed the values and now \"A\" = {0} and the Greater value is now \"B\" = {1}",
                smallerA, greaterB);
            }

            else if (integerA <= integerB)
            {
                Console.WriteLine("Second integer is Greater or Equal on first" );
            }
        }
    }
}
