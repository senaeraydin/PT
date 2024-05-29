using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryModelLayer;

using System.Collections.ObjectModel;
using System.Windows.Input;
using System;
using System.ComponentModel;

namespace LibraryViewModelLayer
{
    public class User : INotifyPropertyChanged
    {
        private static List<User> userList = new List<User>
        {
            new User { UserId = "1", UserName = "user1", FirstName = "First1", LastName = "Last1", Email = "user1@example.com" },
            new User { UserId = "2", UserName = "user2", FirstName = "First2", LastName = "Last2", Email = "user2@example.com" }
        };

        private string userId;
        private string userName;
        private string firstName;
        private string lastName;
        private string email;

        public string UserId
        {
            get => userId;
            set
            {
                userId = value;
                OnPropertyChanged(nameof(UserId));
            }
        }

        public string UserName
        {
            get => userName;
            set
            {
                userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public string Email
        {
            get => email;
            set
            {
                email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Static methods to manipulate user data
        public static List<User> GetUsers()
        {
            return userList;
        }

        public static void AddUser(User user)
        {
            userList.Add(user);
        }

        public static void RemoveUser(string userId)
        {
            var user = userList.FirstOrDefault(u => u.UserId == userId);
            if (user != null)
            {
                userList.Remove(user);
            }
        }
    }
}
