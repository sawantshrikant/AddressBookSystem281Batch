
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml.Linq;


namespace AddressBookSystem281Batch
{
    public class Program
    {  
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Program");
            Console.WriteLine("Enter:\n1: Ability to create a Contact in Address Book\n2: Ability to add a new Contact to Address Book");
            int option = Convert.ToInt32(Console.ReadLine());

            AddressBook addressBook = new AddressBook();

            switch (option)
            {
                case 1:
                    {
                        Contacts contact = new Contacts();

                        Console.WriteLine("Enter First Name:");
                        contact.FirstName = Console.ReadLine();

                        Console.WriteLine("Enter Last Name:");
                        contact.LastName = Console.ReadLine();

                        Console.WriteLine("Enter Address:");
                        contact.Address = Console.ReadLine();

                        Console.WriteLine("Enter City:");
                        contact.City = Console.ReadLine();

                        Console.WriteLine("Enter State:");
                        contact.State = Console.ReadLine();

                        Console.WriteLine("Enter ZIP:");
                        contact.Zip = Console.ReadLine();

                        Console.WriteLine("Enter Phone Number:");
                        contact.PhoneNumber = Console.ReadLine();

                        Console.WriteLine("Enter Email:");
                        contact.Email = Console.ReadLine();

                        addressBook.AddContact(contact);
                        addressBook.DisplayContacts(); // Display the contact after adding
                        break;
                    }
                case 2:
                    {
                        Contacts contact = new Contacts();

                        Console.WriteLine("Enter First Name:");
                        contact.FirstName = Console.ReadLine();

                        Console.WriteLine("Enter Last Name:");
                        contact.LastName = Console.ReadLine();

                        Console.WriteLine("Enter Address:");
                        contact.Address = Console.ReadLine();

                        Console.WriteLine("Enter City:");
                        contact.City = Console.ReadLine();

                        Console.WriteLine("Enter State:");
                        contact.State = Console.ReadLine();

                        Console.WriteLine("Enter ZIP:");
                        contact.Zip = Console.ReadLine();

                        Console.WriteLine("Enter Phone Number:");
                        contact.PhoneNumber = Console.ReadLine();

                        Console.WriteLine("Enter Email:");
                        contact.Email = Console.ReadLine();

                        addressBook.AddContact(contact);
                        addressBook.DisplayContacts(); // Display the contact after adding
                        break;
                    }
                default:
                    Console.WriteLine("Please Enter a Valid Option");
                    break;
            }
        }
    }
    
}
