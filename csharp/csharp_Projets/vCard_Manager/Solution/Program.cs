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
            List<Contact> contacts = new List<Contact>();
            string message = "Bienvenu a la VCard";

            int length = message.Length;

            Console.WriteLine("+" + new string('-', length + 2) + "+");

            Console.WriteLine("| " + message + " |");

            Console.WriteLine("+" + new string('-', length + 2) + "+");

            Console.WriteLine("Vous pouvez choisir une option :");
            Console.WriteLine("");
            Console.WriteLine("1. Afficher tous les contacts. ");
            Console.WriteLine("2. Ajouter un nouveau contact.");
            Console.WriteLine("3. Rechercher un contact par nom.");
            Console.WriteLine("4. Supprimer un contact par nom.");
            Console.WriteLine("5. Exporter un contact dans un fichier(.vcf) séparé. ");
            Console.WriteLine("6. Sortir");
        }
    }
}