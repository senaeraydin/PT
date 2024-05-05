using LibraryDataLayer;

namespace DataTest
{
    [TestClass]
    public class DataTest
    {
        
        private List<User> GenerateMockUsers()
        {
            var users = new List<User>
            {
                new User { UserId = "1", UserName = "user1", FirstName = "Sena", LastName = "Eraydin", Email = "senaeraydin@gmail.com" },
                new User { UserId = "2", UserName = "user2", FirstName = "Ece", LastName = "Atakol", Email = "eceatakol@gmail.com" },
                new User { UserId = "3", UserName = "user3", FirstName = "Sinem", LastName = "Fidan", Email = "sinemfidan@gmail.com" }
            };
            return users;
        }

        
        [TestMethod]
        public void TestMethod1()
        {
            
            var mockUsers = GenerateMockUsers();
            
            Assert.IsNotNull(mockUsers);
        }
    }
}