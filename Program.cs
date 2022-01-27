using System;
using System.Collections.Generic;

namespace addressbook
{
    class Program
    {
        /*
            1. Add the required classes to make the following code compile. */
 
        // internal Contact GetByEmail(string email)
        //     {
        //         return NotImplementedException();
        //     }
    
        /*
 2. Run the program and observe the exception.

 3. Add try/catch blocks in the appropriate locations to prevent the program from crashing
     Print meaningful error messages in the catch blocks.
*/

        static void Main(string[] args)
        {
            // Create a few contacts
            Contact bob = new Contact()
            {
                FirstName = "Bob",
                LastName = "Smith",
                Email = "bob.smith@email.com",
                Address = "100 Some Ln, Testville, TN 11111"
            };
            Contact sue = new Contact()
            {
                FirstName = "Sue",
                LastName = "Jones",
                Email = "sue.jones@email.com",
                Address = "322 Hard Way, Testville, TN 11111"
            };
            Contact juan = new Contact()
            {
                FirstName = "Juan",
                LastName = "Lopez",
                Email = "juan.lopez@email.com",
                Address = "888 Easy St, Testville, TN 11111"
            };


            // Create an AddressBook and add some contacts to it
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact(bob);
            addressBook.AddContact(sue);
            addressBook.AddContact(juan);

        // this gaves an error - Unhandled exception. System.ArgumentException: An item with the same key has already been added. Key: sue.jones@email.com 
        // so we add try and catch at the AddContact method at adressBook class
            addressBook.AddContact(sue);

        // 
            // Create a list of emails that match our Contacts
            List<string> emails = new List<string>() {
            "sue.jones@email.com",
            "juan.lopez@email.com",
            "bob.smith@email.com",
        };

        
            // Insert an email that does NOT match a Contact
            //this gave error message 
            /*Unhandled exception. System.Collections.Generic.KeyNotFoundException: The given key 'not.in.addressbook@email.com' was not present in the dictionary.
   at System.Collections.Generic.Dictionary`2.get_Item(TKey key)
   at addressbook.AddressBook.GetByEmail(String email) in C:\Users\johnn\workspace\backend\bangazon\csharp\exercises\Addressbook\AddressBook.cs:line 34
   at addressbook.Program.Main(String[] args) in C:\Users\johnn\workspace\backend\bangazon\csharp\exercises\Addressbook\Program.cs:line 85 */ 
   //so we add try and catch at line 91 and 100


            emails.Insert(1, "not.in.addressbook@email.com");

            
            //  Search the Ad0dressBook by email and print the information about each Contact
            foreach (string email in emails)
            {
                
                try 
                {
                Contact contact = addressBook.GetByEmail(email);
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Name: {contact.FullName}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine($"Address: {contact.Address}");
                Console.WriteLine();
                }
                catch (KeyNotFoundException ex)
                {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"{email} was not found in the addressbook.\n ");
                //\n = new line
                }
            }


            //   Dictionary<string,string> words = new Dictionary<string, string>();
            //     words.Add("Name", "Encylopedia" );
            //     words.Add("Age", "400" );
            //     words["Add"] = "Does it work";
            //     words.Gohpher = "question";

            //     foreach( KeyValuePair<string,string> word in words )
            //     {
            //                 Console.WriteLine(word.Value);
            //     }
        }
    }
}