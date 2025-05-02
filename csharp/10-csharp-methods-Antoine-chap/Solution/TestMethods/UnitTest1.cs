namespace TestMethods
{
    public class Tests
    {

        [Test]
        public void Test_Sum()
        {
            Assert.That(Methods.Solution.Sum(2, 5), Is.EqualTo(7));
        }

        [Test]
        public void Test_Whos()
        {
            Assert.That(Methods.Solution.Whos("John","Doe",23), Is.EqualTo("Firstname : John\nLastname : Doe\nAge : 23"));
        }

        [Test]
        public void SumAndProduct_ShouldReturnCorrectSumAndProduct()
        {
            int sum, product;
            Methods.Solution.SumAndProduct(3, 4, out sum, out product);

            Assert.That(sum, Is.EqualTo(7), "The sum of 3 and 4 should be 7.");
            Assert.That(product, Is.EqualTo(12), "The product of 3 and 4 should be 12."); 
        }

        [Test]
        public void QuotientAndRemainder_ShouldReturnCorrectQuotientAndRemainder()
        {
            var result = Methods.Solution.QuotientAndRemainder(10, 3);

            Assert.That(result.quotient, Is.EqualTo(3), "The quotient of 10 divided by 3 should be 3.");
            Assert.That(result.remainder, Is.EqualTo(1), "The remainder of 10 divided by 3 should be 1."); 
        }

        [Test]
        public void MethodWithDefaultValue_ShouldReturnDoubleOfProvidedValue()
        {
            int result = Methods.Solution.MethodWithDefaultValue(5);
            Assert.That(result, Is.EqualTo(10), "The result with a value of 5 should be 10.");
        }

        [Test]
        public void MethodWithDefaultValue_ShouldReturnDoubleOfDefaultValue_WhenNoValueIsProvided()
        {
            int result = Methods.Solution.MethodWithDefaultValue();
            Assert.That(result, Is.EqualTo(20), "The result with no provided value should be 20 (10 by default multiplied by 2).");
        }
    }
}