using CiuchApp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CiuchApp.DataContext.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class CiuchAppContextTests
        {
            [TestMethod]
            public void CiuchAppContext_CreateContext()
            {
                var current = CiuchAppMockContext.Pieces;
                Assert.IsNotNull(current);
            }


            [TestMethod]
            public void GetNameOfT_Test()
            {
                var name = GetDropdown<BusinessTrip>();

                Assert.AreEqual(name, "BusinessTrip");

            }

            private string GetDropdown<T>()
            {
                string nameOfController = typeof(T).Name;
                return nameOfController;

            }

        }
    }
}
