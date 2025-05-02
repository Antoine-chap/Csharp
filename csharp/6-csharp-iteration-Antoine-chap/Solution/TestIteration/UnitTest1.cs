namespace TestIteration
{
    public class Tests
    {
        [Test]
        public void Test_SumOfNumbers()
        {
            int result = Iteration.Solution.SumOfNumbers();
            Assert.That(result, Is.EqualTo(100));
        }

        [Test]
        public void Test_Factorial()
        {
            int sum = Iteration.Solution.Factorial(5);
            Assert.That(sum, Is.EqualTo(120));
        }

        [Test]
        public void Test_Factorial_NegativeInput_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Iteration.Solution.Factorial(-5));
        }
    }
}