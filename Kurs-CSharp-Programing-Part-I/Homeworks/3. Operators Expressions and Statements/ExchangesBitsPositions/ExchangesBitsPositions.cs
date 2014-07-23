//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangesBitsPositions
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        int mask = 1 << 3;
        int thirdBit = (number & mask) >> 3;

        //Console.WriteLine(thirdBit);  // test here ctrl+F5 and delete it after test
        mask = 1 << 24;
        int twentyFourthBit = (number & mask) >> 24;

        if (thirdBit == twentyFourthBit)
        {
            Console.WriteLine(number);
            return;
        }
        //Console.WriteLine(twentyFourthBit);  // test here ctrl+F5 and delete it after test

        if (thirdBit == 0)
        {
            // put 0 in 24th position
            mask = ~(1 << 24);   // ~ обръща 0 в 1 и 1 в 0 -> 100 = 011
            number = number & mask;
        }
        else if (thirdBit == 1)
        {
            // put 1 in 24th position
            mask = 1 << 24;
            number = number | mask;
        }

        if (twentyFourthBit == 0)
        {
            // put 0 in third position
            mask = ~(1 << 3);
            number = number & mask;
        }
        else if (twentyFourthBit == 1)
        {
            //put 1 in third position
            mask = 1 << 3;
            number = number | mask;
        }

        Console.WriteLine(number);  // това е резултат 1
        // може да се направи и така да отпечати числото и бинарно.
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number1, 2).PadLeft(32, '0'));

        int mask1 = 1 << 4;
        int fourthBit = (number1 & mask1) >> 4;

        //Console.WriteLine(fourthdBit);  // test here ctrl+F5 and delete it after test
        mask1 = 1 << 25;
        int twentyFifthBit = (number1 & mask1) >> 25;

        if (fourthBit == twentyFifthBit)
        {
            Console.WriteLine(number1);
            return;
        }
        //Console.WriteLine(twentyFifthBit);  // test here ctrl+F5 and delete it after test

        if (fourthBit == 0)
        {
            // put 0 in 25th position
            mask1 = ~(1 << 25);   // ~ обръща 0 в 1 и 1 в 0 -> 100 = 011
            number1 = number1 & mask1;
        }
        else if (fourthBit == 1)
        {
            // put 1 in 25th position
            mask1 = 1 << 25;
            number1 = number1 | mask1;
        }

        if (twentyFifthBit == 0)
        {
            // put 0 in 4th position
            mask1 = ~(1 << 4);
            number1 = number1 & mask1;
        }
        else if (twentyFifthBit == 1)
        {
            //put 1 in 4th position
            mask1 = 1 << 4;
            number1 = number1 | mask1;
        }

        Console.WriteLine(number1);  // това е резултат 2
        // може да се направи и така да отпечати числото и бинарно.
        Console.WriteLine(Convert.ToString(number1, 2).PadLeft(32, '0'));

        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number2, 2).PadLeft(32, '0'));

        int mask2 = 1 << 5;
        int fifthBit = (number2 & mask2) >> 5;

        //Console.WriteLine(fifthBit);  // test here ctrl+F5 and delete it after test
        mask2 = 1 << 26;
        int twentySixstBit = (number2 & mask2) >> 26;

        if (fifthBit == twentySixstBit)
        {
            Console.WriteLine(number2);
            return;
        }
        //Console.WriteLine(twentySixstBit);  // test here ctrl+F5 and delete it after test

        if (fifthBit == 0)
        {
            // put 0 in 26th position
            mask2 = ~(1 << 26);   // ~ обръща 0 в 1 и 1 в 0 -> 100 = 011
            number2 = number2 & mask2;
        }
        else if (fifthBit == 1)
        {
            // put 1 in 26th position
            mask2 = 1 << 26;
            number2 = number2 | mask2;
        }

        if (twentySixstBit == 0)
        {
            // put 0 in 5th position
            mask2 = ~(1 << 5);
            number2 = number2 & mask2;
        }
        else if (twentySixstBit == 1)
        {
            //put 1 in 5th position
            mask2 = 1 << 5;
            number2 = number2 | mask2;
        }

        Console.WriteLine(number2);  // това е резултат 3
        // може да се направи и така да отпечати числото и бинарно.
        Console.WriteLine(Convert.ToString(number2, 2).PadLeft(32, '0'));
    }
}
// Коментар от проверка : Работи, но ми трябваше много време да разбера как да я накарам да работи. 
//Това което е направено е на всеки следващ път да въвеждам полученото число наново. 
//Това не отговаря на условието. Отново си направил/а вход, който не ама никак потребителски ориентиран, даже е объркващ.