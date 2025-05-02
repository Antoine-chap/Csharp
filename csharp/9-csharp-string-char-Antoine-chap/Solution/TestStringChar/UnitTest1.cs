using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestStringChar
{
    public class Tests
    {
        [Test]
        public void Test_ReversedString()
        {
            string result = StringChar.Solution.ReversedString("hello");

            Assert.That(result, Is.EqualTo("olleh"));
        }

        [Test]
        public void Test_ReversedString_Exception()
        {
            var ex = Assert.Throws<ArgumentException>(() => StringChar.Solution.ReversedString(""));
            Assert.That(ex.Message, Is.EqualTo("Input string must not be empty"));
        }

        [Test]
        public void Test_CountVowels()
        {
            string result = StringChar.Solution.CountVowels("You are a nice software developer");
            Assert.That(result, Is.EqualTo($"Number of vowels:{15}"));
        }

        [Test]
        public void Test_CountVowels_Exception()
        {
            var ex = Assert.Throws<ArgumentException>(() => StringChar.Solution.CountVowels(""));
            Assert.That(ex.Message, Is.EqualTo("Input string must not be empty"));
        }

        [Test]
        public void Test_IsPalindrome()
        {
            bool result = StringChar.Solution.isPalindrome("Elu par cette crapule");
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void Test_FirstNonRepeatingCharacter()
        {
           char result = StringChar.Solution.FirstNonRepeatingCharacter("Stress");
           Assert.That(result, Is.EqualTo('t'));
        }
    }
}