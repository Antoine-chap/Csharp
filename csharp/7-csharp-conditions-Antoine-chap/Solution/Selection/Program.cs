namespace Selection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.CanEnterInTheCasino());

            Console.WriteLine("Entrez un nombre:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Solution.SignOfNumber(number));

            try
            {
                Console.WriteLine("Donne moi le prix de ton article.");
                double prixInitial = double.Parse(Console.ReadLine());
                Console.WriteLine("Si tu es membre tape le 2, si tu es etudiant tape le 1 et si l'article est en solde tape le 3.");
                int typeReduction = int.Parse(Console.ReadLine());
                Console.WriteLine(Solution.DiscountPriceCalculator(typeReduction, prixInitial));
            }
            catch (ArgumentException e) { Console.WriteLine("Invalid choice. Please enter a number between 1 and 3."); }

            Console.WriteLine("Donne moi 3 longueur pour faire un triangle.");
            int aSize = int.Parse(Console.ReadLine());
            int bSize = int.Parse(Console.ReadLine());
            int cSize = int.Parse(Console.ReadLine());
            Console.WriteLine(Solution.TriangleClassification(aSize, bSize, cSize));
        }
    }
}
