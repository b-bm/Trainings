// Declare two string variables and assign them with “Hello” and “World”. 
// Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval).
// Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
/* Декларирайте две променливи от тип string и им присвоете стойности "Hello" и "World". 
   Декларирайте променлива от тип object и и присвоете стойността на конкатенацията на двете променливи от тип string 
   (не изпускайте интервала по средата). Декларирайте трета променлива от тип string и я инициализирайте със стойността 
   на променливата от тип object ( трябва да използвате type casting). */

using System;

class DeclaireStringsAndObject
{
    static void Main()
    {
        string hallo = "Hello";
        string world = "World";
        object cont1 = hallo + " " + world;
        string result = (string)cont1;
        Console.WriteLine(result);
    }
}