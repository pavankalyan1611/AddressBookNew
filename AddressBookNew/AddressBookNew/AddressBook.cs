using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookNew
{
    public class AddressBook
    {
        public  List<Contact> addressBook = new List<Contact>();
        public void AddNewContact()
        {
            Contact contact = new Contact();

            Console.WriteLine("enter first name");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("enter second name");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("enter address name");
            contact.Address = Console.ReadLine();

            Console.WriteLine("enter phno name");
            contact.PhNo = Console.ReadLine();

            Console.WriteLine("enter city name");
            contact.City = Console.ReadLine();

            Console.WriteLine("enter state name");
            contact.State = Console.ReadLine();

            Console.WriteLine("enter zip name");
            contact.Zip = Console.ReadLine();

            Console.WriteLine("enter Email name");
            contact.Email = Console.ReadLine();

            addressBook.Add(contact);
        }
        public void Display()
        {
            Console.WriteLine("enter the first name you want to disply:");
            string firstname = Console.ReadLine();
            foreach (Contact contact in addressBook)
            {
                if (contact.FirstName.ToLower() == firstname.ToLower())
                {
                    Console.WriteLine(contact.FirstName);
                    Console.WriteLine(contact.LastName);
                    Console.WriteLine(contact.Address);
                    Console.WriteLine(contact.PhNo);
                    Console.WriteLine(contact.City);
                    Console.WriteLine(contact.State);
                    Console.WriteLine(contact.Zip);
                    Console.WriteLine(contact.Email);
                }
                return;
            }          
                Console.WriteLine("no contact with this firstname\nthere should be min one contactin address book to display, so Add new contact");
                AddNewContact();
                Display();
        }
        public void EditContact()
        {
            Console.WriteLine("enter the first name you want to edit");
            string firstname = Console.ReadLine();
            foreach (Contact contact in addressBook)
            {
                if (contact.FirstName.ToLower() == firstname.ToLower())
                {
                    Console.WriteLine("enter which information you wnat to change");
                    Console.WriteLine("enter 1 to edit last name,2 to change the city, 3 To state, 4 to zip,5 to Email,6 to phonenumber");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("enter the lastname");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("enter the city");
                            contact.City = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("enter the State");
                            contact.State = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("enter the zip");
                            contact.Zip = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("enter the Email");
                            contact.Email = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("enter the phonenumber");
                            contact.PhNo = Console.ReadLine();
                            break;
                    }
                    return;
                }
            }
            Console.WriteLine("no contact with this firstname\n Add New contact to AdderssBook:");
            AddNewContact();
        }
    }
}
