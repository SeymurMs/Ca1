using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika1Aprel
{
    class User
    {
        public User(string name, string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
            this.Name = name;
        }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
