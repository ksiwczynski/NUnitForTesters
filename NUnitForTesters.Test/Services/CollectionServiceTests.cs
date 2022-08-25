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
            var initials = new List<string> { "KS", "PK" };

            var service = new CollectionService(customNames);

            Assert.Multiple(() =>
            {
                Assert.That(customNames.Count, Is.EqualTo(initials.Count));
                CollectionAssert.AreEqual(initials, service.GetInitialsFromNames());
            });
        }
	}
}
