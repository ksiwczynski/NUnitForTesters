using NUnit.Framework;
using NUnitForTesters.Services;

namespace NUnitForTesters.Test.Services
{
    public class CalculatorServiceTests
    {
        [TestCase(3, 1, 2)]
        [TestCase(15, 7, 8)]
        [TestCase(-2, -6, 4)]
        public void AddTest(int result, int a, int b)
        {
            var calc = new CalculatorService();
            Assert.That(result, Is.EqualTo(calc.Add(a, b)));
        }

        [TestCase(2, 4, 2)]
        [TestCase(7, 20, 13)]
        [TestCase(-4, 3, 7)]
        public void SubTest(int result, int a, int b)
		{
			var calc = new CalculatorService();
			Assert.That(result, Is.EqualTo(calc.Sub(a, b)));
        }

		[TestCase(4, 2, 2)]
		[TestCase(21, 3, 7)]
		[TestCase(-9, 3, -3)]
		public void MulTest(int result, int a, int b)
		{
			var calc = new CalculatorService();
			Assert.That(result, Is.EqualTo(calc.Mul(a, b)));
        }

		[TestCase(2, 4, 2)]
		[TestCase(3, 21, 7)]
		[TestCase(4, 48, 12)]
		public void DivTest(int result, int a, int b)
		{
			var calc = new CalculatorService();
			Assert.That(result, Is.EqualTo(calc.Div(a, b)));
		}
    }
}