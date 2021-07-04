using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Create a List \n2.Add New Member");
            Console.WriteLine("Enter an option:");

            int choice = (Convert.ToInt32(Console.ReadLine()));


            switch (choice)
                    { 
                        case 1:
                        Contacts.ReadInputs();
                      break;
                    case 2:
                        Contacts.AddContacts();
                       break;
                    default:

                Console.WriteLine("Exit");
            return;

            }

        }
    }
}
