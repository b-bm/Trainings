// Declare a character variable and assign it with the symbol that has Unicode code 72. 
// Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

using System;

class UnicodeCharacterVariable
{
    static void Main()
    {
        int numberInHex = 0x48;
        Console.WriteLine("The unicode simbol of hexadecimal value 72 is: {0}",(char)numberInHex);
    }
}