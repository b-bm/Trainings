//Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number 
//v has value of 1. Example: v=5; p=1  false.

using System;

class BitOperationOne
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int result = mask & number;
        result = result >> position;

        Console.WriteLine(result);

        if (result == 1)
        {
            Console.WriteLine(true);
            return;  // тази команда прекратява работата до тук ако всичко е ОК.
        }
        else if (result == 0)
        {
            Console.WriteLine(false);
            return;
        }
        // ако има някаква грешка да изпише текст:
        Console.WriteLine("Something is wrong and suks ;)");
    }
}
// Коментар от проверка: Направил/а си вход, ама никак не е потребителски ориентиран. 
//Изхода, също е малко объркващ. Не схващам защо използваш if/else if . Може и без втория if.