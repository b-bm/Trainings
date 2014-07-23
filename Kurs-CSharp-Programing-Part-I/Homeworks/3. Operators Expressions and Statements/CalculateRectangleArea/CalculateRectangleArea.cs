//Write an expression that calculates rectangle’s area by given width and height.
//Напишете израз, който да пресмята лицето на правоъгълник по дадени дължина и височина.

using System;

class CalculateRectangleArea
{
    static void Main()
    {
        int width = 15;
        int height = 6;
        int area = width * height;
        Console.WriteLine(area);

        //Вариянт 2:

        //Console.Write("Enter width: ");
        //string value1 = Console.ReadLine();
        //double width = double.Parse(value1);
        
        //Console.Write("Enter height: ");
        //string value2 = Console.ReadLine();
        //double height = double.Parse(value2);

        //double area = width * height;
        //Console.WriteLine("Rectangle's area is : {0}",area);

        //Вариянт 3 не включен в домашното:

        //Console.Write("Enter Rectangle's Width: ");
        //double width = double.Parse(Console.ReadLine());

        //Console.Write("Enter Rectangle's Height: ");
        //double height = double.Parse(Console.ReadLine());

        //double area = width * height;

        //Console.WriteLine("The area of the rectangle is: {0}",area);
    }
}