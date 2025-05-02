using System.Diagnostics;

namespace TestSelection
{
    public class Tests
    {
        [Test]
        public void Test_Can_Enter_In_TheCasino()
        {
            var input = new StringReader("23");

            Console.SetIn(input);

            var result = Selection.Solution.CanEnterInTheCasino();

            Assert.AreEqual("You can enter! Be welcome!", result);
        }

        [Test]
        public void Test_Can_not_Enter_In_The_Casino()
        {
            var input = new StringReader("13");

            Console.SetIn(input);

            var result = Selection.Solution.CanEnterInTheCasino();

            Assert.AreEqual("Sorry, you can't enter! Be patient!", result);
        }

        [Test]
        public void Test_Get_Validated_Age()
        {
            int age = Selection.Solution.GetValidatedAge("23");

            Assert.That(age, Is.EqualTo(23));

        }

        [Test]
        public void Test_Get_Unvalidated_Age()
        {
            var ex = Assert.Throws<FormatException>(() => Selection.Solution.GetValidatedAge("120"));

            Assert.That(ex.Message, Is.EqualTo("Invalid Age"));
        }

        [Test]
        public void Test_Get_Unvalidated_Age_string()
        {
            var ex = Assert.Throws<FormatException>(() => Selection.Solution.GetValidatedAge("ez"));
            Assert.That(ex.Message, Is.EqualTo("Invalid Age"));
        }

        [Test]
        public void Test_SignOfNumber_Positive()
        {
            Assert.That(Selection.Solution.SignOfNumber(20), Is.EqualTo("The number is positive."));
        }

        [Test]
        public void Test_SignOfNumber_Negative()
        {
            Assert.That(Selection.Solution.SignOfNumber(-2), Is.EqualTo("The number is negative."));
        }

        [Test]
        public void Test_SignOfNumber_Zero()
        {
            Assert.That(Selection.Solution.SignOfNumber(0), Is.EqualTo("The number is zero."));
        }

        [Test]
        public void Test_DiscountPriceCalculatorOption1()
        {
            Assert.That(Selection.Solution.DiscountPriceCalculator(1, 25), Is.EqualTo(22.5));
        }

        [Test]
        public void Test_DiscountPriceCalculatorOption2()
        {
            Assert.That(Selection.Solution.DiscountPriceCalculator(2, 25), Is.EqualTo(23.75));
        }

        [Test]
        public void Test_DiscountPriceCalculatorOption3()
        {
            Assert.That(Selection.Solution.DiscountPriceCalculator(3, 25), Is.EqualTo(20));
        }

        [Test]
        public void Test_DiscountPriceCalculatorError()
        {
           
            int invalidChoice = 4;
            double price = 25;

            var ex = Assert.Throws<ArgumentException>(() => Selection.Solution.DiscountPriceCalculator(invalidChoice, price));

            Assert.That(ex.Message, Is.EqualTo("Invalid choice. Please enter a number between 1 and 3."));
        }

        [Test]
        public void Test_TriangleClassificationEquilateral()
        {
            Assert.That(Selection.Solution.TriangleClassification(10, 10, 10), Is.EqualTo("The triangle is equilateral."));
        }

        [Test]
        public void Test_TriangleClassificationIsosceles()
        {
            Assert.That(Selection.Solution.TriangleClassification(10, 5, 10), Is.EqualTo("The triangle is isosceles."));
        }

        [Test]
        public void Test_TriangleClassificationScalene()
        {
            Assert.That(Selection.Solution.TriangleClassification(10, 5, 8), Is.EqualTo("The triangle is scalene."));
        }

    }
}