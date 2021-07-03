using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Contacts
    {
        public class Person
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string address { get; set; }
            public string state { get; set; }
            public int zip { get; set; }
            public int phnNum { get; set; }
            public string email { get; set; }
        }
        public static List<Person> list = new List<Person>();

        public static void ReadInputs()
        {
            Person person = new Person();
            Console.WriteLine("Enter your First Name :");
            person.firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name :");
            person.lastName = Console.ReadLine();

            Console.WriteLine("Enter your Address :");
            person.address = Console.ReadLine();

            Console.WriteLine("Enter your State :");
            person.state = Console.ReadLine();

            Console.WriteLine("Enter your Zipcode :");
            person.zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Phone Number :");
            person.phnNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Email Address :");
            person.email = Console.ReadLine();

            
            Console.WriteLine("Firstname you entered: " + person.firstName);
            Console.WriteLine("Lastname you entered: " + person.lastName);
            Console.WriteLine("Address you entered: " + person.address);
            Console.WriteLine("State you entered: " + person.state);

            Console.WriteLine("Zipcode you entered: " + person.zip);
            Console.WriteLine("Phone NUmber you entered: " + person.phnNum);
            Console.WriteLine("Email you entered: " + person.lastName);
            Console.ReadLine();
        }
    }
}


