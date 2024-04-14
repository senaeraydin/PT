using LibraryDataLayer;
using LÝbraryLogicLayer;

namespace LogicTest
{
    [TestClass]
    public class LogicTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var libraryData = new LibraryData();
            var logic = new LibraryLogic(libraryData);
            var user = new User
            {
                UserId = "1",
                UserName = "Senaeraydin",
                FirstName = "Sena",
                LastName = "Eraydin",
                Email = "sena.eraydin@gmail.com"
            };


            logic.AddUser(user);
            Assert.IsNotNull(libraryData.Users.Find(u => u.UserId == user.UserId));

        }
    }
}