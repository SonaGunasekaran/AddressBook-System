using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Create a List \n2.Add New Member\n3.Edit Contact\n4.Delete contact\n5.Create Multiple Contact\n6.Mutiple Address Book\n6.Check Duplicates\n7.Search Person");
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
                case 5:
                    Contacts.ReadInputs();
                    break;
                case 6:
                    Contacts.ReadInputs();
                    break;
                case 7:
                    Contacts.ReadInputs();
                    break;
                case 8:
                    Contacts.ReadInputs();
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
        }
    }
}
