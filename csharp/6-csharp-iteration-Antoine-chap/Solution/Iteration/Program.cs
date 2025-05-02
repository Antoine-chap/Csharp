namespace Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.SumOfNumbers());

            Console.WriteLine("Donne un nombre.");
            int number = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Solution.Factorial(number));
            }
            catch (Exception ex){
                Console.WriteLine(ex.ToString());
            }
            
            Solution.multiplication();

            Solution.goodNumber();

            Console.WriteLine(Solution.small());

        }
    }
}
