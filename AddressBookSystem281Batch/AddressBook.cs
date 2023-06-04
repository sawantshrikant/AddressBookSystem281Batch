using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AddressBookSystem281Batch
{
    public class AddressBook
    {
        private List<Contacts> contactsList;

        public AddressBook()
        {
            contactsList = new List<Contacts>();
        }

        public void AddContact(Contacts contact)
        {
            contactsList.Add(contact);
        }

        public void DisplayContacts()
        {
            Console.WriteLine("\nContact List:");
            foreach (Contacts contact in contactsList)
            {
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
}
