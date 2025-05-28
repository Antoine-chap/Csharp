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
            string folderExit = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Contacts_VCF");
            string fileName = "mes_contacts.vcf";
            string pathFull = Path.Combine(folderExit, fileName);

            VCard card = new VCard();
            List<Contact> contacts = new List<Contact>();

            
            string message = "Bienvenu a la VCard";

            int length = message.Length;

            Console.WriteLine("+" + new string('-', length + 2) + "+");

            Console.WriteLine("| " + message + " |");

            Console.WriteLine("+" + new string('-', length + 2) + "+");


            string UserChoice = "";
            while (UserChoice != "6")
            {

                Console.WriteLine("Vous pouvez choisir une option :");
                Console.WriteLine("");
                Console.WriteLine("1. Afficher tous les contacts. ");
                Console.WriteLine("2. Ajouter un nouveau contact.");
                Console.WriteLine("3. Rechercher un contact par nom.");
                Console.WriteLine("4. Supprimer un contact par nom.");
                Console.WriteLine("5. Exporter un contact dans un fichier(.vcf) séparé. ");
                Console.WriteLine("6. Sortir.");

                UserChoice = Console.ReadLine();

                switch (UserChoice)
                {
                    case "1":
                        Console.WriteLine("Afficher tous les contacts.");
                        break;

                    case "2":
                        Console.WriteLine("Ton nom :");
                        string name = Console.ReadLine();
                        Console.WriteLine("Ton prenom :");
                        string firstname = Console.ReadLine();
                        Console.WriteLine("Ton numero de téléphone :");
                        string phone = Console.ReadLine();
                        Console.WriteLine("Ton adresse email :");
                        string mail = Console.ReadLine();
                        var contact = card.AddContact(contacts, name, firstname, phone, mail);
                        var vcfContact = card.ConvertToVCF(contact);




                        break;

                    case "3":
                        Console.WriteLine("Rechercher un contact par nom.");
                        break;

                    case "4":
                        Console.WriteLine("Supprimer un contact par nom.");
                        break;

                    case "5":
                        Console.WriteLine("Exporter un contact dans un fichier(.vcf) séparé.");
                        break;

                    case "6":
                        Console.WriteLine("Sortir.");
                        break;

                    default:
                        Console.WriteLine("Entrez un choix valide entre 1 et 6.");
                        break;

                }

            }

        }
    }
}