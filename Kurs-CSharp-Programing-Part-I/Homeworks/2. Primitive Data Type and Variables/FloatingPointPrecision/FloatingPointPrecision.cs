// Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:
// (5.3 ; 6.01) = false;  (5.00000001 ; 5.00000003) = true

using System;

class FloatingPointPrecision
{
    static void Main()
    {
        float a = 5.03f;
        float b = 5.04f;
        Boolean compare = (a == b);
        Console.WriteLine(" In this case result is: " + compare);
        float c = 5.00000001f;
        float d = 5.00000003f;
        Console.WriteLine(" In second case result is: " + (c == d));
    }
}
// Коментар след проверка: не съм сигурна, че си разбрал точно условието и проблемите, които поставя тази задача.
//Мисля, че идеята беше да се ползва decimal заради прецизността. 
//Понеже и във форума доста питания имаше и нямаше май официално прието кое да е вярно, приемам решението ти за вярно....
//За справка просто прегледай и моя вариант ако искаш:

//Console.WriteLine("Enter first number: ");
//decimal firstNumber = decimal.Parse(Console.ReadLine());
//Console.WriteLine("Enter second number: ");
//decimal secondNumber = decimal.Parse(Console.ReadLine());

//if (Math.Abs(firstNumber - secondNumber) < 0.000001m)
//    {
//        Console.WriteLine("Numbers are equal!");
//    }
//else
//    {
//        Console.WriteLine("Numbers are not equal!");
//    }