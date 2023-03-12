using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook2
{
    public class Addressbook
    {
        //public Contact[] ContactInfo { get; set; }
        //public int NumberOfContacts { get; set; }

        //public Addressbook()
        //{
        //    ContactInfo = new Contact[100];
        //    NumberOfContacts = 0;
        //}
        //public void AddContact(Contact contact)
        //{
        //    bool isDuplicate = ContactInfo.Any(existingContact => existingContact != null && existingContact.firstName == contact.firstName && existingContact.lastName == contact.lastName);

        //    if (!isDuplicate)
        //    {
        //        ContactInfo[NumberOfContacts] = contact;
        //        NumberOfContacts++;
        //        Console.WriteLine("Contact added.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("A contact with the same name already exists.");
        //    }
        //}


        //public void PrintContact()
        //{
        //    for (int i = 0; i < NumberOfContacts; i++)
        //    {
        //        Console.WriteLine("Name: {0} {1}\nCountry: {2}\nPhone: {3}\nEmail: {4}\n",
        //            ContactInfo[i].firstName, ContactInfo[i].lastName, ContactInfo[i].country, ContactInfo[i].phoneNumber, ContactInfo[i].email);
        //    }
        //}

        //public void SearchbyCountry(string country)
        //{
        //    var results = ContactInfo.Where(contact => contact != null && contact.country == country);

        //    if (results.Any())
        //    {
        //        Console.WriteLine($"Contacts in {country}:");
        //        foreach (var result in results)
        //        {
        //            Console.WriteLine($"{result.firstName},{result.lastName},{result.country}, {result.phoneNumber}, {result.email}");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine($"No contacts found in {country}.");
        //    }
        //}

        public List<Contact> ContactInfo { get; set; }
        public Dictionary<string, List<Contact>> ContactsByCountry { get; set; }

        public Addressbook()
        {
            ContactInfo = new List<Contact>();
            ContactsByCountry = new Dictionary<string, List<Contact>>();
        }

        public void AddContact(Contact contact)
        {
            if (!ContactInfo.Contains(contact))
            {
                ContactInfo.Add(contact);

                if (!ContactsByCountry.ContainsKey(contact.country))
                {
                    ContactsByCountry[contact.country] = new List<Contact>();
                }
                ContactsByCountry[contact.country].Add(contact);
            }
        }

        public void PrintContact()
        {
            foreach (var contact in ContactInfo)
            {
                Console.WriteLine("Name: {0} {1}\nCountry: {2}\nPhone: {3}\nEmail: {4}\n",
                    contact.firstName, contact.lastName, contact.country, contact.phoneNumber, contact.email);
            }
        }

        public List<Contact> GetContactsbyCountry(string country)
        {
            return ContactsByCountry.ContainsKey(country) ? ContactsByCountry[country] : new List<Contact>();
        }

    }
}
