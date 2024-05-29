
using LibraryModelLayer;

using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelTest
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void User_ShouldInitializeCorrectly()
        {
            // Arrange
            var userId = "1";
            var userName = "User1";
            var firstName = "First1";
            var lastName = "Last1";
            var email = "user1@example.com";

            // Act
            var user = new LibraryDataLayer.User
            {
                UserId = userId,
                UserName = userName,
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };

            // Assert
            Assert.AreEqual(userId, user.UserId);
            Assert.AreEqual(userName, user.UserName);
            Assert.AreEqual(firstName, user.FirstName);
            Assert.AreEqual(lastName, user.LastName);
            Assert.AreEqual(email, user.Email);
        }
        [TestMethod]
        public void Event_ShouldInitializeCorrectly()
        {
            // Arrange
            var eventId = "1";
            var eventName = "Event1";
            var startTime = DateTime.Now;
            var endTime = startTime.AddHours(1);

            // Act
            var libraryEvent = new Event
            {
                EventId = eventId,
                EventName = eventName,
                StartTime = startTime,
                EndTime = endTime
            };

            // Assert
            Assert.AreEqual(eventId, libraryEvent.EventId);
            Assert.AreEqual(eventName, libraryEvent.EventName);
            Assert.AreEqual(startTime, libraryEvent.StartTime);
            Assert.AreEqual(endTime, libraryEvent.EndTime);
        }
    }
}

