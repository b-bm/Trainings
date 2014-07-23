/* A marketing firm wants to keep record of its employees. 
   Each record would have the following characteristics – first name, family name, age, gender (m or f), 
   ID number, unique employee number (27560000 to 27569999). 
   Declare the variables needed to keep the information for a single employee using appropriate data types 
   and descriptive names.
   Фирма, занимаваща се с маркетинг, иска да пази запис с данни на нейните служители. 
   Всеки запис трябва да има следната характе­ристика – първо име, фамилия, възраст, пол (‘м’ или ‘ж’) 
   и уникален номер на служителя (27560000 до 27569999). 
   Декларирайте необходи­мите променливи, нужни за да се запази информацията за един служи­тел, като използвате 
   подходящи типове данни и описателни имена. */
 
using System;

class MarketingFirm
{
    static void Main()
    {
        string FirstName = "Getsby";
        string LastName = "Great";
        sbyte Age = 35;
        char Gender = 'M';
        int UniqueNumber = 27569459;
        Console.WriteLine("Employees record 1:\nFirst Name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}\nUnique Number: {4}",FirstName,LastName,Age,Gender,UniqueNumber);
    }
}