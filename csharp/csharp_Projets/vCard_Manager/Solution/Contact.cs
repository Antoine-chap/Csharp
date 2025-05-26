using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vCard_Manager
{
    public class Contact
    {
        public string Name { get; set; }

        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }

        public Contact(string name,string firstname, string phone, string mail)
        {
            Name = name;
            FirstName = firstname;
            Phone = phone;
            Mail = mail;
        }
         public override string ToString()
        {
            return $"{Name} - {FirstName} - {Phone} - {Mail}";
        }
    }
}