/* Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
 * Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.
 */ 

using System;
class PrintTriangle
{
    static void Main()
    {
        char symbol = '\u00A9';
        Console.WriteLine("  {0}", symbol);
        Console.WriteLine(" {0}{0}{0}", symbol);
        Console.WriteLine("{0}{0}{0}{0}{0}", symbol);

        //Ver.2:
        //Console.WriteLine("   \u00A9   " + Environment.NewLine + "  \u00A9 \u00A9  " + Environment.NewLine + " \u00A9   \u00A9 " + Environment.NewLine + "\u00A9 \u00A9 \u00A9 \u00A9");  
    }
}
// Коментар след проверка: вярна и коректо направена с това, което е предадено до тук.
//Една подсказка - за да ти се принтира правилно знака използвай следното: Console.OutputEncoding = Encoding.UTF8; 
//Слагаш го на реда след декларирането на char променливата. Това, заедно с добавянето горе на using System.Text; 
//понеже си го изтрил... аз никога не си ги трия, щото при някои случай са си полезни иначе трябва да ги търсиш, 
//да знаеш кое ти трябва и да добавяш за да ти се получат нещата. Но това си е мое мнение. 