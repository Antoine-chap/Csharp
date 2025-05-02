namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number1 = 2;
            int number2 = 5;
            Console.WriteLine(Solution.Sum(number1, number2));

            string firstName = "John";
            string name = "Doe";
            int age = 23;
            Console.WriteLine(Solution.Whos(firstName, name, age));

            int number3 = 3;
            int number4 = 4;
            int somme;
            int product;
            Solution.SumAndProduct(number3, number4, out somme, out product);
            Console.WriteLine(somme);
            Console.WriteLine(product);

            Console.WriteLine(Solution.QuotientAndRemainder(10, 3));

            Console.WriteLine(Solution.MethodWithDefaultValue());


        }
    }
}
