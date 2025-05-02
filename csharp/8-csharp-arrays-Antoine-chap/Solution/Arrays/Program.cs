namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution.array1();

            int[] numbers = { 41, 51, 17, 45, 12 };

            Console.WriteLine(Solution.Sum(numbers));

            Console.WriteLine(Solution.Average(numbers));

            Solution.MaxAndMin(numbers, out int max, out int min);

            Console.WriteLine("Donne moi le nombre de nombres que tu souhaite dans le tableau.");
            int spaceArray = int.Parse(Console.ReadLine());
            int[] array = new int[spaceArray];
            Console.WriteLine("Ecris tes nombres.");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Solution.SortAndArray(array);

            int[] x = { 1, 2, 4, 2, 1 };
            Solution.Palindrome(x);

        }
    }
}
