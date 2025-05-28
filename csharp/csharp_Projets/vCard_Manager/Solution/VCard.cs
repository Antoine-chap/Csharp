using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vCard_Manager
{
    public class VCard
    {
        public Contact AddContact(List<Contact> contacts, string name, string firstname, string phone, string mail)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Le nom ne peut pas être vide");
            }
            if (string.IsNullOrWhiteSpace(firstname))
            {
                throw new ArgumentNullException("Le prénom ne peut pas être vide");
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                throw new ArgumentNullException("Le numéro de téléphone ne peut pas être vide");
            }
            if (string.IsNullOrWhiteSpace(mail))
            {
                throw new ArgumentNullException("L'email ne peut pas être vide");
            }


            Contact newContact = new Contact(name, firstname, phone, mail);

            contacts.Add(newContact);

            return newContact;



            Console.WriteLine($"Contact ajouté : {newContact.Name} {newContact.FirstName}");
        }

        public string ConvertToVCF(Contact contact)
        {
            StringBuilder vcard = new StringBuilder();

            vcard.AppendLine("BEGIN:VCARD");
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

        public void CreateFileIfNecessary(string roadFile)
        {
            try
            {
                if (!Directory.Exists(roadFile))
                {
                    Directory.CreateDirectory(roadFile);
                    Console.WriteLine($"Dossier créé : {roadFile}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la création du dossier : {ex.Message}");
            }
        }
    }

    // public void ExportToVCF(List<Contact> contacts, string roadFile)
}
