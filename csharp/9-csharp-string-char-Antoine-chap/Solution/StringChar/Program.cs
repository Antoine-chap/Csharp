namespace StringChar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string original = "hello";
                Console.WriteLine(Solution.ReversedString(original));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string text = "You are a nice software developer";
                Console.WriteLine(Solution.CountVowels(text));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                string text2 = "Elu par cette crapule";
                Console.WriteLine(Solution.isPalindrome(text2));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                string text3 = "Stress";
                Console.WriteLine(Solution.FirstNonRepeatingCharacter(text3));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
