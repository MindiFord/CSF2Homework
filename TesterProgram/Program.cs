using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            s1.FirstName = "Johnny";
            s1.LastName = "Castle";
            s1.Id = "1963";
            s1.Gpa = 2.9f;

            Console.WriteLine(s1);

            Student s2 = new Student("Vida", "Boheme", "1995", 3.8f);

            Console.WriteLine(s2);

            Console.WriteLine("\n\n");

            Vehicle v1 = new Vehicle();

            v1.Make = "Triumph";
            v1.Model = "Mayflower";
            v1.Year = 1949;
            v1.Weight = 2050f;

            Console.WriteLine(v1);

            Vehicle v2 = new Vehicle("Mercury", "Bobcat", 1974, 2300);

            Console.WriteLine(v2);

            Console.WriteLine("\n\n");

            Login l1 = new Login();

            l1.Username = "TwinMom";
            l1.Password = "12345";

            Console.WriteLine(l1);


            Login l2 = new Login("CharliesMom", "12345");

            Console.WriteLine(l2);

            Console.WriteLine("\n\n");

            ContactInfo c1 = new ContactInfo();
            c1.StreetAddress = "2101 N Lightburne Ave";
            c1.City = "Liberty";
            c1.State = "Missouri";
            c1.Zip = "64068";
            c1.Phone = "(816) 555-5555";
            c1.Email = "MarkHall@Hallmark.com";

            Console.WriteLine(c1 + "\n");

            ContactInfo c2 = new ContactInfo("1201 S 12th Street", "St. Joseph", "Missouri", "64503", "(816) 555-6666", "jessejames@somewhere.com");

            Console.WriteLine(c2 + "\n");

            Customer cust1 = new Customer("11111", "Mark", "Hall", c1);
            Customer cust2 = new Customer();
            cust2.CustomerId = "22222";
            cust2.FirstName = "Jesse";
            cust2.LastName = "James";
            cust2.ContactInformation = c2;

            Console.WriteLine(cust1 + "\n" + cust2 + "\n");

            CreditCardAccount credit1 = new CreditCardAccount(54241807, cust1, 5000, false, .03m);

            CreditCardAccount credit2 = new CreditCardAccount();
            credit2.AccountNumber = 41286705;
            credit2.CustomerInfo = cust2;
            credit2.Balance = 1500;
            credit2.IsPastDue = true;
            credit2.AnnualInterestRate = .12m;

            Console.WriteLine(credit1 + "\n" + credit2 + "\n");
            


            
        }
    }
}
