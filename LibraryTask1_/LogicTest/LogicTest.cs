using LibraryDataLayer;
using LibraryLogicLayer_;

namespace LogicTest
{
    [TestClass]
    public class LogicTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mockDataRepository = new MockDataRepository();
            var logic = new LibraryLogicL(mockDataRepository);
            var user = new User
            {
                UserId = "1",
                UserName = "Senaeraydin",
                FirstName = "Sena",
                LastName = "Eraydin",
                Email = "sena.eraydin@gmail.com"
            };


            logic.AddUser(user);
           
            Assert.AreEqual(1, mockDataRepository.Users.Count); 
            Assert.AreEqual(user, mockDataRepository.Users[0]);
        }
    }
}