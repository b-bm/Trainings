// Declare five variables choosing for each of them the most appropriate of the types 
// byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
// 52130, -115, 4825932, 97, -10000.

using System;
    namespace DeclaireFiveVariables
    {
        class DeclaireFiveVariables
        {
            static void Main()
            {
                sbyte a = -115;
                byte b = 97;
                short c = -10000;
                ushort d = 52130;
                uint f = 4825932;
                Console.WriteLine("Print fife variables:\nsbyte = {0}\nbyte = {1}\nshort = {2}\nushort = {3}\nuint = {4}",a,b,c,d,f);
            }
        }
    }