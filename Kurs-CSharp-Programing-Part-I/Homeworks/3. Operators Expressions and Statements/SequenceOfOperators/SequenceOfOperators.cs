//We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n 
//to hold the value v at the position p from the binary representation of n.
//Example: n = 5 (00000101), p=3, v=1  13 (00001101) n = 5 (00000101), p=2, v=0  1 (00000001)

using System;

class SequenceOfOperators
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        if (value == 0)
        {
            int mask = ~(1 << position); // ~ обръща 0 в 1 и 1 в 0 -> 100 = 011
            int result = number & mask;
            Console.WriteLine(result);   // test here
        }
        else if (value == 1)
        {
            int mask = (1 << position);
            int result = number | mask;  // оператор или -> 1 и 0 = 1, 1 и 1 = 1
            Console.WriteLine(result);
        }   
        else
        {    
            Console.WriteLine("Something's wrong here!"); 
        }
    }
}
// Коментар от проверка: Направил/а си вход, ама никак не е потребителски ориентиран.