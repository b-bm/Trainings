//3. Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
//Напишете програма, която чете от конзолата поредица от цели числа и отпечатва най-малкото и най-голямото от тях.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalAndMaximal
{
    class MinimalAndMaximal
    {
        static void Main()
        {
            Console.Write("Enter howmany numbers you want to enter: ");
            byte allNumbers = byte.Parse(Console.ReadLine());

            Console.Write(" 1: ");
            int minValue = int.Parse(Console.ReadLine());
            int maxValue = minValue;

            for (int i = 2; i <= allNumbers; i++)
            {
                Console.Write(" {0}: ", i);
                int number = int.Parse(Console.ReadLine());

                if (number > maxValue)
                    maxValue = number;
                else if (number < minValue)
                    minValue = number;
            }

            Console.WriteLine("Greatest number is: {0}", maxValue);
            Console.WriteLine("Smaller number is: {0}", minValue);

            // Var.2. 

            //Console.Write("Enter howmany numbers you want to enter: ");
            //int numberCount = int.Parse(Console.ReadLine());
            //int[] numberArray = new int[numberCount];

            //for (int i = 0; i < numberCount; i++)
            //{
            //    numberArray[i] = int.Parse(Console.ReadLine());
            //}

            //int minimumValue = numberArray[0];
            //int maximumValue = numberArray[0];
            //for (int i = 0; i < numberArray.Length; i++)
            //{
            //    minimumValue = numberArray.Min();
            //    maximumValue = numberArray.Max();
            //}
            //Console.WriteLine("Smaller Value is: {0}", minimumValue);
            //Console.WriteLine("Biggest Value is: {0}", maximumValue);
        }
    }
}
