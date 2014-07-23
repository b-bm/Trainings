//Write an expression that checks if given integer is odd or even.
//Напишете израз, който да проверява дали дадено цяло число е четно или нечетно.

using System;

namespace EvenOrOdd
{
    class EvenOrOdd
    {
        static void Main()
        {
            //int number = 136;
            //int result = number % 2;
            //Console.WriteLine(result);

            Console.Write("Enter some Number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

        }
    }
}