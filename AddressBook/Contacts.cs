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
            list.Add(person);
            ListPeople();
            Console.ReadLine();
        }

        

            private static void ListPeople()
            {
                if (list.Count == 0)
                {
                    Console.WriteLine("Your address book is empty. Press any key to continue.");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Here are the current people in your address book:\n");
                foreach (var value in list)
                {
                    GetInfo(value);
                }
               
            }



        
            static void GetInfo(Person value)
            {

                Console.WriteLine("Firstname you entered: " + value.firstName);
                Console.WriteLine("Lastname you entered: " + value.lastName);
                Console.WriteLine("Address you entered: " + value.address);
                Console.WriteLine("State you entered: " + value.state);

                Console.WriteLine("Zipcode you entered: " + value.zip);
                Console.WriteLine("Phone NUmber you entered: " + value.phnNum);
                Console.WriteLine("Email you entered: " + value.email);

            }
            
        }
    }



