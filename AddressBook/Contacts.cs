﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
        //list holds variables in a specific order
        public static List<Person> list;
        // Creating a dictionary
        public static Dictionary<string, List<Person>> dictionary = new Dictionary<string, List<Person>>();
        //Add contacts into the list
        public static void AddContacts()
        {
            Console.WriteLine("1.Add New Contact \n2.List the contacts\n3.Edit datails\n4.Delete Contact");
            Console.WriteLine("Enter an option:");
            int choice = (Convert.ToInt32(Console.ReadLine()));
            switch (choice)
            {
                case 1:
                    Contacts.ReadInputs();
                    break;
                case 2:
                    Contacts.ListPeople();
                    break;
                case 3:
                    Contacts.EditDetails();
                    break;
                case 4:
                    Contacts.DeleteDetails();
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
        }
        //Get input from user
        public static void ReadInputs()
        {
            Person person = new Person();
            string bookName;
            //Console.WriteLine("Enter your Address Book Name: ");
            //string bookName = Console.ReadLine();
            list = new List<Person>();
            while (true)
            {
                Console.WriteLine("Enter your Address Book Name: ");
                bookName = Console.ReadLine();
                if (dictionary.Count > 0)
                {
                    if (!dictionary.ContainsKey(bookName))
                    {
                        dictionary.Add(bookName, list);
                    }
                    else
                    {
                        Console.WriteLine("Address Book is already exists!");
                    }
                }
                else
                {
                    break;
                }
                
            }
            Console.WriteLine("Enter number of contacts you want to add :");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Enter your First Name :");
                string firstName = Console.ReadLine();
                Person result = list.Find(x => x.firstName.Equals(firstName));
                if (result == null)
                {
                    person.firstName = firstName;
                }
                else
                {
                    Console.WriteLine("Your name  already exists");
                    break;
                }
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
            }
            dictionary.Add(bookName, list);
            ListPeople();
            Console.ReadLine();
        }
        //view the contacts in a dictionary
        private static void ListPeople()
        {
            if (dictionary.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Here are the current people in your address book:\n");
            //Access the elements in the dictionary by key
            foreach (KeyValuePair<string, List<Person>> x in dictionary)
            {
                foreach (var value in x.Value)
                {
                    GetInfo(value);
                }
            }

        }
        // Display the values
        static void GetInfo(Person value)
        {
            Console.WriteLine("Firstname you entered: " + value.firstName);
            Console.WriteLine("Lastname you entered: " + value.lastName);
            Console.WriteLine("Address you entered: " + value.address);
            Console.WriteLine("State you entered: " + value.state);
            Console.WriteLine("Zipcode you entered: " + value.zip);
            Console.WriteLine("Phone Number you entered: " + value.phnNum);
            Console.WriteLine("Email you entered: " + value.email);
            AddContacts();
        }
        //To edit the details in address book
        public static void EditDetails()
        {
            Console.WriteLine("Enter your first to edit details:");
            string name = Console.ReadLine();
            foreach (var value in list)
            {
                //check the names are equal
                if (value.firstName.Equals(name))
                {
                    Console.WriteLine("Enter your new Email Id: ");
                    value.email = Console.ReadLine();
                    Console.WriteLine("Enter your new ZipCode: ");
                    value.zip = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter your new Phone Number: ");
                    value.phnNum = Convert.ToInt32(Console.ReadLine());
                    GetInfo(value);
                }
            }
        }
        // Delete details in address book
        public static void DeleteDetails()
        {
            Console.WriteLine("Enter your first to delete contact:");
            string name = Console.ReadLine();
            foreach (var value in list)
            {
                if (value.firstName.Equals(name))
                {
                    list.Remove(value);
                    Console.WriteLine("The contact you entered is deleted successfully");
                    AddContacts();
                }
            }
        }
    }
}




