//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.
//Напишете израз, който да проверява дали третата цифра (отдясно на ляво) на 1732 е 7.

using System;

class ThirdDigit
{
    static void Main()
    {
        int number = 1732;
        bool thirdDigitIs7 = (number / 100) % 10 == 7;
        Console.WriteLine(thirdDigitIs7);
    }
}