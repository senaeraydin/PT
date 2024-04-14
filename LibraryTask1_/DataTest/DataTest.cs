using LibraryDataLayer;

namespace DataTest
{
    [TestClass]
    public class DataTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var user = new User();

            Assert.IsNotNull(user);
        }
    }
}