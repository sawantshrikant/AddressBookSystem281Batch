using AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem281Batch
{
    public class AddressBookMain
    {
        List<Contacts> addressBookSystem = new List<Contacts>();

        public void AddContact()
        {
            Console.WriteLine("Welcome to Address Book Program!");
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
            Console.WriteLine("Enter PostalCode:");
            contact.PostalCode = Console.ReadLine();
            Console.WriteLine("Enter PhoneNumber:");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            contact.Email = Console.ReadLine();
            addressBookSystem.Add(contact);
        }
        public void DisplayContact()
        {
            foreach (var contact in addressBookSystem)
            {
                Console.WriteLine("\nDisplaying Contact Information:");
                Console.WriteLine("First Name: " + contact.FirstName);
                Console.WriteLine("Last Name: " + contact.LastName);
                Console.WriteLine("Address: " + contact.Address);
                Console.WriteLine("City: " + contact.City);
                Console.WriteLine("State: " + contact.State);
                Console.WriteLine("Postal Code: " + contact.PostalCode);
                Console.WriteLine("Phone Number: " + contact.PhoneNumber);
                Console.WriteLine("Email: " + contact.Email);

            }



        }
        public void EditContact()
        {
            Console.WriteLine("Edit using FirstName");
            string name = Console.ReadLine();
            foreach (var contact in addressBookSystem)
            {
                if (contact.FirstName == name)
                {
                    Console.WriteLine("Enter Option to Edit \n 1.FirstName \n 2.LastName \n 3.Address \n 4.City \n 5.State \n 6.Postal Code \n 7.PhoneNumber \n 8.Email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            contact.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            contact.LastName = Console.ReadLine();
                            break;
                        case 3:
                            contact.Address = Console.ReadLine();
                            break;
                        case 4:
                            contact.City = Console.ReadLine();
                            break;
                        case 5:
                            contact.State = Console.ReadLine();
                            break;
                        case 6:
                            contact.PostalCode = Console.ReadLine();
                            break;
                        case 7:
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 8:
                            contact.Email = Console.ReadLine();
                            break;



                    }
                }

            }

        }
    }
}

