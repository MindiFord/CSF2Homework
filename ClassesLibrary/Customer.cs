using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        //fields

        //properties
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInformation { get; set; }
               
        //ctors
        public Customer(string customerId, string firstName, string lastName, ContactInfo contactInformation)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }

        public Customer()
        {

        }

        //methods
        public override string ToString()
        {
            //return base.ToString();
            return $"Customer ID: {CustomerId}\n" +
                $"First Name: {FirstName}\n" +
                $"Last Name: {LastName}\n" +
                $"Contact Information: {ContactInformation}\n";
        }//end ToString()

        
    }//end class
}//end namespace
