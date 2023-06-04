
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
            Console.WriteLine("Welcome to Address Book Program!");
            AddressBookMain addressBookSystem = new AddressBookMain();

            addressBookSystem.AddContact();
            addressBookSystem.EditContact();
            addressBookSystem.DisplayContact();

            addressBookSystem.DeleteContact();
            addressBookSystem.DisplayContact();

            addressBookSystem.AddMultipleContacts();
            addressBookSystem.DisplayContact();
        }
            
    }
    
}
