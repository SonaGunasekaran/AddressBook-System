using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Create a List \n2.Add New Member\n3.Edit Contact");
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
    }
}
