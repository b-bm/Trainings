// A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
// bank name, IBAN, BIC code and 3 credit card numbers associated with the account. 
// Declare the variables needed to keep the information for a single bank account using the appropriate data types 
// and descriptive names.

using System;

class BankAccount
{
    static void Main()
    {
        string FirstName = "Danny";
        string MiddleName = "Petroff";
        string LastName = "Stoyanov";
        decimal balance = 234567890123456568721.89M;
        string BankName = "First Investment Bank";
        string iban = "FIB23468024679013245632";
        string bic = "FIB45";
        ulong CreditCard1 = 6856125498807;
        ulong CreditCard2 = 2820346792084;
        ulong CreditCard3 = 5236467921466;

        Console.WriteLine("{0} {1} {2}", FirstName, MiddleName, LastName);
        Console.WriteLine("Total ammount of:\n{0} leva in {1}", balance, BankName);
        Console.WriteLine("Personal Account Information\nIBAN:{0}\nBIC:{1}", iban, bic);
        Console.WriteLine("Credit Card(s) Number:\nFirst Card:{0}\nSecond Card:{1}\nThird Card:{2}", CreditCard1, CreditCard2, CreditCard3);

        // Вариянт 2 - НЕ включен в предадената домашна!
        //Console.WriteLine("Enter your first name:");
        //string firstName = Console.ReadLine();
        //Console.WriteLine("Enter your middle name");
        //string middleName = Console.ReadLine();
        //Console.WriteLine("Enter your last name");
        //string lastName = Console.ReadLine();

        //Console.WriteLine("Your first name is: {0}\nYour middle name is: {1}\nYour last name is: {2}", firstName, middleName, lastName);
        //string theNameOfTheBank = "First Investment Bank";
        //Console.WriteLine("Your bank is {0}", theNameOfTheBank);
        //decimal balanceOfMoney = 500000000;
        //Console.WriteLine("Available bank balance: {0}lv", balanceOfMoney);
        //string iBan = "BGN09FIBBG8035757659713";
        //Console.WriteLine("IBAN / {0}", iBan);
        //string bicCode = "BIC8035";
        //Console.WriteLine("BIC CODE / {0}", bicCode);
        //ulong creditCard1 = 3606357267921546;
        //Console.WriteLine("The number of your first credit card is: {0}", creditCard1);
        //ulong creditCard2 = 9824857921346787;
        //Console.WriteLine("The number of your second credit card is: {0}", creditCard2);
        //ulong creditCard3 = 3168048743561023;
        //Console.WriteLine("The number of your third credit card is: {0}", creditCard3);
    }
}