using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika1Aprel
{
    class Contacts
    {
        public Dictionary<string, string> contacts = new Dictionary<string, string>();

        public void AddContact(User user)
        {
            if (contacts.ContainsKey(user.Name))
                throw new AlreadyExistsException("Qaqas agilli ol PLS!?");
                  
            contacts.Add(user.Name, user.PhoneNumber);
            return;
            


        }
        public Dictionary<string, string> GetAllContacts()
        {
            return contacts;
        }

        public string GetContactByName(string val)
        {
            //foreach (var item in contacts)
            //{
            //    if (item.Key == val)
            //    {
            //        return item.Value;
            //    }
            //}
            //return null;
            return contacts.GetValueOrDefault(val);
        }
    }
}
