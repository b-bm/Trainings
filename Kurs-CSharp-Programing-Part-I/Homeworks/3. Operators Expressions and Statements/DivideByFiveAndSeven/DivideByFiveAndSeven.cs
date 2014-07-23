//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 
//in the same time.
//Напишете булев израз, който да проверява дали дадено цяло число се дели на 5 и на 7 без остатък.

using System;

class DivideByFiveAndSeven
{
    static void Main()
    {
        bool divideBy5 = 60 % 5 == 0;
        bool divideBy7 = 35 % 7 == 0;
        bool divide = divideBy5 && divideBy7;
        Console.WriteLine(divide);
    }
}

//Условието е да се провери ЕДНО цяло число дали се дели едновременно и на 5 и на 7.