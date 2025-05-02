namespace StringChar
{
    public class Solution
    {
        public static string ReversedString(string x)
        {

            if (string.IsNullOrEmpty(x))
            {
                throw new ArgumentException("Input string must not be empty");
            }

            char[] charArray = x.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string CountVowels(string x)
        {

            if (string.IsNullOrEmpty(x))
            {
                throw new ArgumentException("Input string must not be empty");
            }

            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            int result = x.Count(c => vowels.Contains(char.ToLower(c)));
            return $"Number of vowels:{result}";

        }

        public static bool isPalindrome(string x)
        {

            if (string.IsNullOrEmpty(x))
            {
                throw new ArgumentException("Input string must not be empty");
            }

            string lower = x.ToLower().Replace(" ", "");
            char[] charArray = lower.ToCharArray();
            char[] charArray2 = (char[])charArray.Clone();
            Array.Reverse(charArray2);
            if (new string(charArray) == new string(charArray2))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public static char FirstNonRepeatingCharacter(string x)
        {
            if (string.IsNullOrEmpty(x))
            {
                throw new ArgumentException("Input string must not be empty");
            }

            string lower = x.ToLower().Replace(" ", "");
            char[] charArray = lower.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                bool repeat = false;
                for (int j = 0; j < charArray.Length; j++)
                {
                    if (i != j)
                    {
                        if (charArray[i] == charArray[j])
                        {
                            repeat = true;
                        }
                    }

                }
                if (repeat == false){
                    return charArray[i];
                }
            }
            return '\0';
        }
    }
}
