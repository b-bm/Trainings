//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
//Напишете израз, който проверява дали дадено положително число n (n ≤ 100) е просто. 
//(т.е. се дели без остатък само на себе си и на единица). 37 е просто.

using System;

class CheckIsNumberPrime
{
    static void Main()
    {

        Console.Write("Enter some digit from 1 to 100: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 2; i < Math.Sqrt(number); i++)

            if (number % i == 0)
            {
                Console.WriteLine("The number is NOT prime");
            }
            else
            {
                Console.WriteLine("The number is prime");
                break;
            }
        
        // Вариянт 2:
        
        //Console.Write("Enter some digit from 1 to 100: ");
        //int number = int.Parse(Console.ReadLine());
        //if ((number > 1) && (number <= 100))
        //{
        //    if (number == 2 || number == 3 || number == 5 || number == 7)
        //    {
        //        Console.WriteLine("The number " + number + " is prime");
        //    }
        //    else
        //    {
        //        if (number % 2 == 0 || number % 3 == 0 || number % 4 == 0 || number % 5 == 0 || number % 6 == 0 || number % 7 == 0 || number % 8 == 0 || number % 9 == 0 || number % 10 == 0)
        //        {
        //            Console.WriteLine("The number " + number + " is not prime");
        //        }
        //        else
        //        {
        //            Console.WriteLine("The number " + number + " is prime");
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Number is out of range");
        //}

        // Вариянт 3 - не довършен (някъде се губи нишката :) )!
 
        //Console.Write("Enter some digit from 1 to 100: ");
        //int number = int.Parse(Console.ReadLine());

        //if (number / number % number == 0)
        //{
        //    Console.WriteLine("The number is prime");
        //}
        //else
        //{
        //    Console.WriteLine("The number is NOT prime");
        //}
    }
}

//проверката за прости числа, при даденото условие е следната:
//Проверяваме дали числото се дели без остатък на всички числа в интервала 2 до корен квадратен от числото. 
//Ако се дели без остатък на някое от тези числа, то числото не е просто. Ако не се дели без остатък - то е просто. 
//Идеята с цикъла е супер, но ти куца проверката и извеждането на крайния резултат. Аз бих сложил булева променлива, 
//която да записва резултата от проверката за деление. В зависимост от крайната стойност на променливата, 
//числото е или не е просто.