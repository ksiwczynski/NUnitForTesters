using NUnit.Framework;
using NUnitForTesters.Services;
using System.Collections.Generic;

namespace NUnitForTesters.Test.Services
{
    public class CollectionServiceTests
    {
        [Test]
        public void GetInitialsFromNamesConstructorTest()
        {
            var service = new CollectionService();

			CollectionAssert.IsNotEmpty(service.Names);
            CollectionAssert.AllItemsAreNotNull(service.Names);
			CollectionAssert.AllItemsAreUnique(service.Names);
        }
	}
}
