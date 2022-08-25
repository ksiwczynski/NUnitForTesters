using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using NUnitForTesters.Services;
using System.Threading;

namespace NUnitForTesters.Test.Services
{
    public class WeirdServiceTests
    {
        [Test]
        [Timeout(2000)]
        public void ThisMethodWillTimeoutTest()
        {
            StringAssert.IsMatch("This method should timeout", WeirdService.ThisMethodWillTimeout());
        }

        [Test]
        public void ThisMethodWillThrowExceptionIfParameterIsZero([Range(0, 10)] int parameter)
        {
            Assert.That(WeirdService.ThisMethodWillThrowExceptionIfParameterIsZero(parameter), Is.EqualTo(100 / parameter).Within(0.1));
        }
	}
}
