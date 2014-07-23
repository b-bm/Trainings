//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
//Напишете израз, който да проверява дали третия бит на дадено число е 1 или 0.

using System;

    class FindThirdBit
    {
        static void Main()
        {
            int number = 973;   // 973 = 1 ; 17 = 0
            int position = 3;
            int mask = 1 << position;
            int NumberAndMask = number & mask;
            int bit = NumberAndMask >> position;
            Console.WriteLine("Third bit of digit is " + bit);

            //Console.Write("Enter some number: ");
            //int number = int.Parse(Console.ReadLine());
            //int p = 3;
            //int mask = 1 << p;
            //int NumberAndMask = number & mask;
            //int bit = NumberAndMask >> p;
            //Console.WriteLine("Third bit of digit is " + bit);
        }
    }

// 8 = 1000 (in binary)
// 1000 = number
// 0001 = mask
// местим 3 позиции в ляво = 1000
// result:
// 1000 = number
// 1000 = mask
// сравняваме числото и маската - имаме 1 и 1 = true
// ако е false = 0