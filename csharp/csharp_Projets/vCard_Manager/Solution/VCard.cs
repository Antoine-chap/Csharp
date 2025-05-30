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
                throw new ArgumentException("Le nom ne peut pas être vide");
            }
            if (string.IsNullOrWhiteSpace(firstname))
            {
                throw new ArgumentException("Le prénom ne peut pas être vide");
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                throw new ArgumentException("Le numéro de téléphone ne peut pas être vide");
            }
            if (string.IsNullOrWhiteSpace(mail))
            {
                throw new ArgumentException("L'email ne peut pas être vide");
            }

            Contact newContact = new Contact(name, firstname, phone, mail);
            contacts.Add(newContact);

            Console.WriteLine($"Contact ajouté : {newContact.Name} {newContact.FirstName}");
            return newContact;
        }

        public string ConvertToVCF(Contact contact)
        {
            StringBuilder vcard = new StringBuilder();

            vcard.AppendLine("BEGIN:VCARD");
            vcard.AppendLine("VERSION:3.0");
            vcard.AppendLine($"FN:{contact.FirstName} {contact.Name}");
            vcard.AppendLine($"N:{contact.Name};{contact.FirstName};;;");

            if (!string.IsNullOrWhiteSpace(contact.Phone))
            {
                vcard.AppendLine($"TEL:{contact.Phone}");
            }
            if (!string.IsNullOrWhiteSpace(contact.Mail))
            {
                vcard.AppendLine($"EMAIL:{contact.Mail}");
            }

            vcard.AppendLine("END:VCARD");

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

        public string GeneratePathWithDate(string FileBase, string prefixe = "contacts")
        {
            string horodatage = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            string nameFile = $"{prefixe}_{horodatage}.vcf";
            return Path.Combine(FileBase, nameFile);
        }

        public string GetDefaultPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts_VCF");
        }

        public bool ValidateRoadFile(string roadFile)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(roadFile))
                    return false;

                string extension = Path.GetExtension(roadFile);
                if (extension.ToLower() != ".vcf")
                    return false;

                string dossier = Path.GetDirectoryName(roadFile);
                if (!string.IsNullOrEmpty(dossier) && !Directory.Exists(dossier))
                {
                    Directory.CreateDirectory(dossier);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void ExportToVCFIndividuals(List<Contact> contacts, string exitFile = null)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(exitFile))
                {
                    exitFile = GetDefaultPath();
                }
                CreateFileIfNecessary(exitFile);

                int countCreatesFile = 0;
                List<string> createsFile = new List<string>();

                foreach (Contact contact in contacts)
                {
                    string secureNameFile = GenerateSecureFileName(contact.Name);
                    string roadFile = Path.Combine(exitFile, $"{secureNameFile}.vcf");

                    roadFile = ManageDuplicatesFileName(roadFile);

                    using (StreamWriter writer = new StreamWriter(roadFile, false, Encoding.UTF8))
                    {
                        string vcard = ConvertToVCF(contact);
                        writer.Write(vcard);
                    }

                    createsFile.Add(roadFile);
                    countCreatesFile++;
                    Console.WriteLine($"Fichier créé : {Path.GetFileName(roadFile)} pour {contact.Name}");
                }
                Console.WriteLine($"\n=== EXPORTATION TERMINÉE ===");
                Console.WriteLine($"Nombre de contacts exportés : {countCreatesFile}");
                Console.WriteLine($"Dossier de destination : {exitFile}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de l'exportation : {ex.Message}");
            }
        }

        private string GenerateSecureFileName(string contactName)
        {
            if (string.IsNullOrWhiteSpace(contactName))
            {
                return "contact_sans_nom";
            }

            char[] caracteresInterdits = Path.GetInvalidFileNameChars();
            string secureName = contactName;

            foreach (char c in caracteresInterdits)
            {
                secureName = secureName.Replace(c, '_');
            }
            secureName = secureName.Replace(' ', '_');
            
            if (secureName.Length > 50)
            {
                secureName = secureName.Substring(0, 50);
            }
            return secureName;
        }

        private string ManageDuplicatesFileName(string roadFile)
        {
            if (!File.Exists(roadFile))
            {
                return roadFile;
            }

            string dossier = Path.GetDirectoryName(roadFile);
            string nameNoExtension = Path.GetFileNameWithoutExtension(roadFile);
            string extension = Path.GetExtension(roadFile);

            int count = 1;
            string newRoad;

            do
            {
                string newName = $"{nameNoExtension}_{count}{extension}";
                newRoad = Path.Combine(dossier, newName);
                count++;
            }
            while (File.Exists(newRoad));

            return newRoad;
        }

        public void DisplayContacts(List<Contact> contacts)
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("\nAucun contact trouvé.");
                return;
            }

            Console.WriteLine($"\n=== Liste des contacts ({contacts.Count}) ===");
            for (int i = 0; i < contacts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {contacts[i]}");
            }
        }

        public Contact SearchContactByName(List<Contact> contacts, string searchName)
        {
            if (string.IsNullOrWhiteSpace(searchName))
                return null;

            return contacts.FirstOrDefault(c => 
                c.Name.IndexOf(searchName, StringComparison.OrdinalIgnoreCase) >= 0 ||
                c.FirstName.IndexOf(searchName, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        public bool RemoveContactByName(List<Contact> contacts, string searchName)
        {
            Contact contactToRemove = SearchContactByName(contacts, searchName);
            if (contactToRemove != null)
            {
                contacts.Remove(contactToRemove);
                Console.WriteLine($"Contact supprimé : {contactToRemove.Name} {contactToRemove.FirstName}");
                return true;
            }
            return false;
        }
    }
}
