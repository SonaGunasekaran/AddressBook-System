using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Continue = true;
            while (Continue)
            {
                Console.WriteLine("1.Add New Contact \n2.List the contacts\n3.Edit datails\n4.Delete Contact\n5.Search by City or state\n6.View City or State\n7.Count City or State\n8.Sort Values\n9.Write into File");
                Console.WriteLine("Enter an option:");
                int choice =Convert.ToInt32(Console.ReadLine());
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
                    case 5:
                        Contacts.SearchCityOrState();
                        break;
                    case 6:
                        Contacts contact = new Contacts();
                        contact.ViewCityOrStateName();
                        break;
                    case 7:
                        Contacts contact1 = new Contacts();
                        contact1.CountCityOrState();
                        break;
                    case 8:
                        Contacts.SortValues();
                        break;
                    case 9:
                        Contacts file = new Contacts();
                        file.WriteIntoFile();
                        file.ReadFromCsvFile();
                        file.WriteCsvFile();
                        break;
                    case 0:
                        Continue = false;
                        break;
                    default:
                        Console.WriteLine("Exit");
                        break;
                }
            }
        }
    }
}

