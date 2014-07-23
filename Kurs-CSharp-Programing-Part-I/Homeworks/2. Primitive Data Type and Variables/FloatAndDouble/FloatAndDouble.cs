// Which of the following values can be assigned to a variable of type float and which to a variable of type double:
// 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

class FloatAndDouble
{
    static void Main()
    {
        float floatA = 12.345f;
        float floatB = 3456.091f;
        double doubleC = 34.567839023;
        double doubleD = 8923.1234857;
        Console.WriteLine("Float variables ar: \n {0}\n {1}",floatA,floatB);
        Console.WriteLine("Double variables ar: \n {0}\n {1}",doubleC,doubleD);

        /* вариянт 2
        float floatA = 12.345f;
        float floatB = 3456.091f;
        double doubleC = 34.567839023;
        double doubleD = 8923.1234857;
        Console.WriteLine("Float variable is: " + floatA);
        Console.WriteLine("Float variable is: " + floatB);
        Console.WriteLine("Double variable is: " + doubleC);
        Console.WriteLine("Double variable sis: " + doubleD); */
     }
}