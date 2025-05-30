using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vCard_Manager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string exitFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Contacts_VCF");

            VCard card = new VCard();
            List<Contact> contacts = new List<Contact>();

            string message = "Bienvenue dans le gestionnaire vCard";
            int length = message.Length;

            Console.WriteLine("+" + new string('-', length + 2) + "+");
            Console.WriteLine("| " + message + " |");
            Console.WriteLine("+" + new string('-', length + 2) + "+");

            string userChoice = "";
            while (userChoice != "6")
            {
                Console.WriteLine("\nVous pouvez choisir une option :");
                Console.WriteLine("1. Afficher tous les contacts");
                Console.WriteLine("2. Ajouter un nouveau contact");
                Console.WriteLine("3. Rechercher un contact par nom");
                Console.WriteLine("4. Supprimer un contact par nom");
                Console.WriteLine("5. Exporter tous les contacts dans des fichiers (.vcf) séparés");
                Console.WriteLine("6. Sortir");
                Console.Write("\nVotre choix : ");

                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        card.DisplayContacts(contacts);
                        break;

                    case "2":
                        try
                        {
                            Console.Write("Nom : ");
                            string name = Console.ReadLine();
                            Console.Write("Prénom : ");
                            string firstname = Console.ReadLine();
                            Console.Write("Numéro de téléphone : ");
                            string phone = Console.ReadLine();
                            Console.Write("Adresse email : ");
                            string mail = Console.ReadLine();

                            var contact = card.AddContact(contacts, name, firstname, phone, mail);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"Erreur : {ex.Message}");
                        }
                        break;

                    case "3":
                        Console.Write("Entrez le nom ou prénom à rechercher : ");
                        string searchTerm = Console.ReadLine();
                        var foundContact = card.SearchContactByName(contacts, searchTerm);
                        
                        if (foundContact != null)
                        {
                            Console.WriteLine($"Contact trouvé : {foundContact}");
                        }
                        else
                        {
                            Console.WriteLine("Aucun contact trouvé avec ce nom.");
                        }
                        break;

                    case "4":
                        Console.Write("Entrez le nom du contact à supprimer : ");
                        string nameToDelete = Console.ReadLine();
                        
                        if (!card.RemoveContactByName(contacts, nameToDelete))
                        {
                            Console.WriteLine("Aucun contact trouvé avec ce nom.");
                        }
                        break;

                    case "5":
                        if (contacts.Count == 0)
                        {
                            Console.WriteLine("Aucun contact à exporter.");
                        }
                        else
                        {
                            card.ExportToVCFIndividuals(contacts, exitFile);
                        }
                        break;

                    case "6":
                        Console.WriteLine("Au revoir !");
                        break;

                    default:
                        Console.WriteLine("Entrez un choix valide entre 1 et 6.");
                        break;
                }
            }
        }
    }
}