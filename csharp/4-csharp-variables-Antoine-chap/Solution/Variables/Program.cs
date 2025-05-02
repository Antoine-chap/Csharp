namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.SayHello("John"));
        
            Console.WriteLine(Solution.AgeToFloat(23));

            Console.WriteLine(Solution.CelciusToFarenheit(2));

            Console.WriteLine(Solution.KilometersToMiles(2));

            Console.WriteLine(Solution.Random10());
        }
    }
}
