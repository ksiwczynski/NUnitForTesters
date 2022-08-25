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
	}
}
