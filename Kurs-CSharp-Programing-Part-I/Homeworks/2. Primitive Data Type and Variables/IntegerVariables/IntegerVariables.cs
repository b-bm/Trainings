// Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class IntegerVariables
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        a = a + b;
        b = a - b;
        Console.WriteLine("a = {0}\nb = {1}", a, b);

        //След проверка коментар: 11 задача - съжалявам, но е абсолютно объркана. 
        //Това, което се искаше е да размениш стойностите на двете променливи. 
        //Пробвай този код - дано да ти помогне да разбереш условието какво е.
        
        //int five = 5;
        //Console.WriteLine("five = " + five);
        //int ten = 10;
        //Console.WriteLine("ten = " + ten);
        //int temp = 0;
        //temp = five;
        //five = ten;
        //ten = temp;
        //Console.WriteLine("five = " + five);
        //Console.WriteLine("ten = " + ten);
    }
}