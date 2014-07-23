// Create a console application that calculates and prints the square of the number 12345.

using System;

class CalculateSquareOfNumber
{
    static void Main()
    {
        Console.WriteLine(12345*12345);
        
        // or (или по този начин):
        //int number = 12345;
        //int square = number * number;
        //Console.WriteLine("The squared number of {0} is {1}", number, square);
        
        // or (а може и така):
        //Console.WriteLine("Enter a number for Square:");
        //int Number = Convert.ToInt16(Console.ReadLine());
        //int SquareNumber = Number * Number;
        //Console.WriteLine("Square of Number {0} is: {1}", Number, SquareNumber);                    
    }
}