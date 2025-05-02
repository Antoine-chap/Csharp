namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donner votre âge");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(Solution.IsAdult(age));

            Console.WriteLine("Donne moi ton nombre.");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Solution.EvenOrOdd(number));

            Console.WriteLine("Donne 2 nombres.");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Solution.Add(number1, number2));
            
            Console.WriteLine("Donne 2 nombres.");
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            Console.WriteLine(Solution.Max(number3, number4));
        }
    }
}
