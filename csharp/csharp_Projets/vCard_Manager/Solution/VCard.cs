using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace
{
    public class VCard
    {
        public void AddContact(List<Contact> contacts, string name, string firstname, string phone, string mail)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Le nom ne peut pas être vide");
            }

            Contact newContact = new Contact(name, phone, mail);

            contacts.Add(newContact);

            Console.WriteLine($"Contact ajouté : {newContact}");
        }

        private string ConvertToVCard(Contact contact)
        {
            StringBuilder vcard = new StringBuilder();

            vcard.AppendLine("BEGIN:VCARD");
            vcard.AppendLine("VERSION:3.0");
            vcard.AppendLine($"FN:{contact.Name} {contact.FirstName}");


            if (!string.IsNullOrWhiteSpace(contact.Phone))
            {
                vcard.AppendLine($"TEL:{contact.Phone}");
            }
            if (!string.IsNullOrWhiteSpace(contact.Mail))
            {
                vcard.AppendLine($"{contact.Mail}");
            }

            vcard.AppendLine("End:VCARD");

            return vcard.ToString();
        }
        
        public void ExportToVCF(List<Contact> contacts, string roadFile)
    }
}