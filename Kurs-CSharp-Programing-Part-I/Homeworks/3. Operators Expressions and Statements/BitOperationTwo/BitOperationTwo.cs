//Write an expression that extracts from a given integer i the value of a given bit number b. 
//Example: i=5; b=2  value=1.

using System;

class BitOperationTwo
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int result = mask & number;
        result = result >> position;

        Console.WriteLine(result);
    }
}
// Коментар от проверка: Направил/а си вход, ама никак не е потребителски ориентиран. 