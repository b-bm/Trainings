//3. A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company and its manager and prints them on the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyData
{
    class PrintCompanyData
    {
        static void Main()
        {
            string companyName = "BM BIO FIRE";
            string companyAddress = "Plovdiv, Ivan Vazov str. 139";
            string companyPhone = "+359-32-963579";
            string companyFax = "+359-32-963697";
            string companyWeb = "http://bmbiofire.com";
            string companyManager = "Stoyan Petrov";

            string managerFirstName = "Stoyan";
            string managerLastName = "Petrov";
            string managerAge = "33";
            string managerPhone = "+359-887-586921";

            Console.WriteLine("The Company is: {0} \n Company Address is: {1} \n Company Phone Number is: {2} \n Company Fax Number is: {3} \n Company Web Site is: {4} \n Company Manager is: {5}",
                companyName, companyAddress, companyPhone, companyFax, companyWeb, companyManager);

            Console.WriteLine("Company Manager Contacts are: \n First Name: {0} \n Last Name: {1} \n Age: {2} \n Phone Number: {3}",
                managerFirstName, managerLastName, managerAge, managerPhone);
        }
    }
}
