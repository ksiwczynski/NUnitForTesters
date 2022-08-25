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

        [Test]
        public void GetInitialsFromNamesCustomTest()
		{
			var customNames = new List<string> { "Konrad Siwczyński", "Przemysław Kardas" };

			var service = new CollectionService(customNames);

            var initials = service.GetInitialsFromNames();

            Assert.Multiple(() =>
            {
                Assert.That(initials.Count, Is.EqualTo(customNames.Count));
                CollectionAssert.AreEqual(new List<string> { "KS", "PK" }, initials);
            });
        }
	}
}
