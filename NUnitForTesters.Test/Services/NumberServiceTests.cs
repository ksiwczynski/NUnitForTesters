using NUnit.Framework;
using NUnitForTesters.Services;

namespace NUnitForTesters.Test.Services
{
    public class NumberServiceTests
    {
        // 0 & 50 fail test
        [Test]
        public void IsItTheAnswerToUltimateQuestionOfLifeTest([Range(-10, 110)] int number)
        {
            var numService = new NumberService();
            StringAssert.DoesNotMatch("That should not happen at all", numService.IsItTheAnswerToUltimateQuestionOfLife(number), "Number: {0}", number);
        }

        [Test]
        public void IsPrimeTest([Range(-10, 10)] int i)
		{
			var numService = new NumberService();
            Assert.IsFalse(numService.IsPrime(i));
		}
	}
}
