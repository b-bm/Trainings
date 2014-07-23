//8. Write a program that, depending on the user's choice inputs int, double or string variable. 
//If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
//The program must show the value of that variable as a console output. Use switch statement.
//Напишете програма, която по избор на потребителя прочита от конзолата променлива от тип int, double или string. 
//Ако променливата е int или double, трябва да се увеличи с 1. Ако променливата е string, 
//трябва да се прибави накрая символа "*". Отпечатайте получения резултат на конзолата. Използвайте switch конструкция.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTypeOfInputValue
{
    class CheckTypeOfInputValue
    {
        static void Main()
        {
            double number = 0;
            string text = string.Empty;

            Console.WriteLine("Choose your type of variable: ");
            Console.WriteLine("\n 1: for int");
            Console.WriteLine(" 2: for double");
            Console.WriteLine(" 3: for string");
            Console.Write("\nNow Enter your choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Enter integer number: ");
                    number = int.Parse(Console.ReadLine());
                    Console.WriteLine("New value = {0}", number + 1);
                    break;
                case "2":
                    Console.Write("Enter real number: ");
                    number = double.Parse(Console.ReadLine());
                    Console.WriteLine("New value = {0}", number + 1);
                    break;
                case "3":
                    Console.Write("Enter a text: ");
                    text = Console.ReadLine();
                    Console.WriteLine("New value = {0}[*]", text);
                    break;
                default:
                    Console.WriteLine("Error! Wrong input data! ... Try again pls.");
                    break;
            }
        }
    }
}
