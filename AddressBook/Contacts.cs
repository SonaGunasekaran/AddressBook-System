using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace AddressBook
{
    class Contacts
    {
        public class Person
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string address { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public int zip { get; set; }
            public int phnNum { get; set; }
            public string email { get; set; }
        }
        //list holds variables in a specific order
        public static List<Person> list;
        private List<Person> viewCityState;
        private static List<Person> Sortlist;
        // Creating a dictionary
        public static Dictionary<string, List<Person>> dictionary = new Dictionary<string, List<Person>>();
        //Get input from user
        public static void ReadInputs()
        {
            string bookName;

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
                Person person = new Person();
                list = new List<Person>();
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
                Console.WriteLine("Enter your city :");
                person.city = Console.ReadLine();
                Console.WriteLine("Enter your state:");
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
        public static void ListPeople()
        {
            if (dictionary.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            //Access the elements in the dictionary by key
            foreach (KeyValuePair<string, List<Person>> x in dictionary.OrderBy(x => x.Key))
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
            Console.WriteLine("Address you entered: " + value.city);
            Console.WriteLine("State you entered: " + value.state);
            Console.WriteLine("Zipcode you entered: " + value.zip);
            Console.WriteLine("Phone Number you entered: " + value.phnNum);
            Console.WriteLine("Email you entered: " + value.email);
        }
        //search By city or state name
        public static void SearchCityOrState()
        {
            string name;
            Console.WriteLine("Enter City or State name to search:");
            name = Console.ReadLine();
            foreach (KeyValuePair<string, List<Person>> n in dictionary)
            {
                var search = list.Find(x => x.city.Equals(name) || x.state.Equals(name));
                foreach (var l in dictionary)
                {
                    GetInfo(search);
                }
            }
        }
        //View contacts either by city or state name
        public void ViewCityOrStateName()
        {
            string name, personName;
            viewCityState = new List<Person>();
            Console.WriteLine("Enter City or State name to View Contacts:");
            name = Console.ReadLine();
            Console.WriteLine("Enter person name to View Contacts:");
            personName = Console.ReadLine();
            if (dictionary.Count == 0)
            {
                Console.WriteLine("Your address book is empty");

            }
            else
            {
                foreach (KeyValuePair<string, List<Person>> view in dictionary)
                {
                    viewCityState = view.Value.FindAll(x => x.firstName.Equals(personName) && x.state.Equals(name) || x.city.Equals(name) && x.firstName.Equals(personName));
                }
                if (viewCityState.Count > 0)
                {
                    foreach (var x in viewCityState)
                    {
                        GetInfo(x);
                    }
                }
                else
                {
                    Console.WriteLine("No such Persons exists");
                }
            }
        }
        public void CountCityOrState()
        {
            string name;
            int count = 0;
            Console.WriteLine("Enter City or State name to View Contacts:");
            name = Console.ReadLine();

            if (dictionary.Count == 0)
            {
                Console.WriteLine("Your address book is empty");

            }
            else
            {
                foreach (KeyValuePair<string, List<Person>> view in dictionary)
                {
                    viewCityState = view.Value.FindAll(x => x.city.Equals(name) || x.state.Equals(name));
                }
                if (viewCityState.Count > 0)
                {
                    foreach (var x in viewCityState)
                    {
                        GetInfo(x);
                    }
                    //count the city and states
                    count = viewCityState.Count;
                    Console.WriteLine("The total persons in " + " " + name + "are" + " " + count);
                }
                else
                {
                    Console.WriteLine("You have entered wrong details");
                }
            }
        }

        //To edit the details in address book
        public static void EditDetails()
        {
            Console.WriteLine("Enter your firstName to edit details:");
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
            Console.WriteLine("Enter your firstName to delete contact:");
            string name = Console.ReadLine();
            foreach (var value in list)
            {
                if (value.firstName.Equals(name))
                {
                    list.Remove(value);
                    Console.WriteLine("The contact you entered is deleted successfully");
                }
            }
        }
        
        public static void SortValues()
        {
            //sorted list to display values
            Sortlist = new List<Person>();
            foreach (KeyValuePair<string, List<Person>> s in dictionary)
            {
                foreach (var i in s.Value)
                {
                    Sortlist.Add(i);
                }
            }
            //sort based on zip
            foreach (var i in Sortlist.OrderBy(p => p.zip))
            {
                GetInfo(i);
            }
            //sort based on state
            foreach (var i in Sortlist.OrderBy(p=> p.state))
            {
                GetInfo(i);
            }
            //sort based on city
            foreach (var i in Sortlist.OrderBy(p => p.city))
            {
                GetInfo(i);
            }

        }
        //write the data into the file
        public void WriteIntoFile()
        {
            string filepath = @"C:\Users\Sona G\source\repos\AddressBook\AddressBook\Filetest.txt";
            if (File.Exists(filepath))
            {
                StreamWriter writer = new StreamWriter(filepath);
                foreach (KeyValuePair<string, List<Person>> i in dictionary)
                { 
                    writer.WriteLine("AddressBook Name:" + i.Key);
                    foreach (var list in i.Value)
                    {
                        string s = "Name:" + list.firstName + " " + list.lastName + " Address:" + list.address + " City:" + list.city + " State:" + list.state + " Zipcode:" + list.zip + " Ph.No:" + list.phnNum;
                        writer.WriteLine(s);
                    }
                    writer.WriteLine();
                }
                writer.Close();
                ReadFromFile(filepath);
            }
            else
            {
                Console.WriteLine("File not exists");
            }
        }
        //read the data from the file 
        public void ReadFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                //read all the data in the single text
                string text = File.ReadAllText(filePath);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("File not exist");
            }
        }
    }
}






