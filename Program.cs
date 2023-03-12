namespace AddressBook2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to master branch of Address Book problem part 2.");

            Addressbook addressbook = new Addressbook();
            Contact newContact1 = new Contact("kundan", "kumar", "India", "7975461361", "kundannie2016@gmail.com");
            Contact newContact2 = new Contact("vinay", "katare", "India", "87654321", "vinaykatare1234@gmail.com");
            Contact newContact3 = new Contact("nihal", "srivatava", "usa", "87654321", "nihal123@gmail.com");

            addressbook.AddContact(newContact1);
            addressbook.AddContact(newContact2);
            addressbook.AddContact(newContact3);

            //addressbook.SearchbyCountry("usa");
            //addressbook.SearchbyCountry("India");
            //addressbook.PrintContact();

            //string country = "India";
            //List<Contact> contactInCountry = addressbook.GetContactsbyCountry(country);
            //Console.WriteLine("\nContacts in {0}:", country);
            //foreach (var contact in contactInCountry)
            //{
            //    Console.WriteLine("{0} {1}", contact.firstName, contact.lastName);
            //}

            addressbook.PrintContactCountbyCountry();
        }
    }
}