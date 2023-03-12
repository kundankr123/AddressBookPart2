using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook2
{
    public class Addressbook
    {
        public Contact[] ContactInfo { get; set; }
        public int NumberOfContacts { get; set; }

        public Addressbook()
        {
            ContactInfo = new Contact[100];
            NumberOfContacts = 0;
        }
        public void AddContact(Contact contact)
        {
            bool isDuplicate = ContactInfo.Any(existingContact => existingContact != null && existingContact.firstName == contact.firstName && existingContact.lastName == contact.lastName);

            if (!isDuplicate)
            {
                ContactInfo[NumberOfContacts] = contact;
                NumberOfContacts++;
                Console.WriteLine("Contact added.");
            }
            else
            {
                Console.WriteLine("A contact with the same name already exists.");
            }
        }


        public void PrintContact()
        {
            for (int i = 0; i < NumberOfContacts; i++)
            {
                Console.WriteLine("Name: {0} {1}\nCountry: {2}\nPhone: {3}\nEmail: {4}\n",
                    ContactInfo[i].firstName, ContactInfo[i].lastName, ContactInfo[i].country, ContactInfo[i].phoneNumber, ContactInfo[i].email);
            }
        }
    }
}
