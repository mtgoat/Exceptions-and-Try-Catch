using System;
using System.Collections.Generic;

namespace Addressbook
{
    
        public class AddressBook
        {
            //this creates a dictionary object named _contactList and inside, it has string as a type of key and Contact object as a value
            private Dictionary<string, Contact> _contactList {get; set;} = new Dictionary<string, Contact>();
            
            //this is a method or function that runs when a information is added to the addressbook class and this method adds an e-mail as a value and personObject as a value and this is one way of doing it.
            public void AddContact(Contact personObjContact )
            {
                // Emailaddress = personObjContact;
                _contactList.Add(personObjContact.Email, personObjContact);
            }
            // this is another way of adding conact to the address book by Micheal T Jordan

            /* public void AddContact(Contact person)
            {
                _contactList[person.Email] = person;
            } */

            public Contact GetByEmail(string email)
            {
                return _contactList.email;
            }

            // this is another way of adding conact to the address book by Micheal T Jordan

            /* public Contact GetByEmail(string email)
            {
                return _contactList[Email];
            } */
        }
}