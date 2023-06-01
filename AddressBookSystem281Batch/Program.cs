using System;

namespace AddressBookSystem281Batch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program!");
            Contacts contact = new Contacts();

            Console.Write("Enter first name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("Enter address: ");
            contact.Address = Console.ReadLine();

            Console.Write("Enter city: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter state: ");
            contact.State = Console.ReadLine();

            Console.Write("Enter ZIP code: ");
            contact.Zip = Console.ReadLine();

            Console.Write("Enter phone number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("Enter email address: ");
            contact.Email = Console.ReadLine();

           
            Console.WriteLine("\nContact Information:");
            Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
            Console.WriteLine($"Address: {contact.Address}");
            Console.WriteLine($"City: {contact.City}");
            Console.WriteLine($"State: {contact.State}");
            Console.WriteLine($"ZIP: {contact.Zip}");
            Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
            Console.WriteLine($"Email: {contact.Email}");
        }


    }
}
