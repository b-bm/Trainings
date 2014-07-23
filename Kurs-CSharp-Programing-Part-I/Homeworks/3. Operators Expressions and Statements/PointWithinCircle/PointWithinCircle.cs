//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).


using System;

class PointWithinCircle
{
    static void Main()
    {
        decimal pointX = 4.5m;
        decimal pointY = 1.3m;
        decimal centerX = 2.3m;
        decimal centerY = 3.9m;

        decimal resultX = (pointX - centerX) * (pointX - centerX);
        decimal resultY = (pointY - centerY) * (pointY - centerY);

        decimal endResult = resultX + resultY;

        decimal radius = 5;
        bool isPointWithinCircle = endResult < radius * radius;
        Console.WriteLine(isPointWithinCircle);
    }
}