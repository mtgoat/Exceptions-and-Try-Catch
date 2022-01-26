using System;
using System.Collections.Generic;

namespace Addressbook
{
    
        public class AddressBook
        {
            private Dictionary<string, Contact> _contactList {get; set;} = new Dictionary<string, Contact>();
            
            // public Contact Emailaddress {get; set;}
            public void AddContact(Contact personObjContact )
            {
                // Emailaddress = personObjContact;
                _contactList.Add(personObjContact.Email, personObjContact);
            }

            public Contact GetByEmail(string email)
            {
                throw new NotImplementedException();
            }
        }
}