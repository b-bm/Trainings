/* Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
   Do the above in two different ways: with and without using quoted strings.
   Декларирайте две променливи от тип string и им присвоете стойност "The "use" of quotations causes difficulties." 
   (без първите и последни кавички). В едната променлива използвайте quoted string, а в другата не го използвайте. 
*/
using System;

class DeclaireTwoStrings
{
    static void Main()
    {
        string variables = "The \"use\" of quotations causes difficulties. \n \"The \"use\" of quotations causes difficulties.\"";
        Console.WriteLine(variables);
        
        // вариянт 2:
        /*string var1 = "The \"use\" of quotations causes difficulties.";
        string var2 = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(var1);
        Console.WriteLine(var2); */
    }
}
// Коментар след проверка: Вариант 2 е верният, според условието на задачата.