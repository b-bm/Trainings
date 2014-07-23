// Find online more information about ASCII (American Standard Code for Information Interchange) 
// and write a program that prints the entire ASCII table of characters on the console.

using System;

namespace ASCIITable
{
    class ASCIITable
    {
        static void Main()
        {
            for (int code = 0; code <= 255; code++)
            {
                char symbol = (char)code;
                Console.WriteLine("{0} {1}",code,symbol);
            }
        }
    }
}