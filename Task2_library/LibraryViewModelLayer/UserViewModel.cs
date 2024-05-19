using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryModelLayer;
using LibraryLogicLayer;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System;

namespace LibraryViewModelLayer
{
    public class UserViewModel : ViewModelBase
    {
        private readonly LibraryLogicL libraryLogic;

        public ObservableCollection<User> Users { get; set; }
        public User SelectedUser { get; set; }

        public ICommand AddUserCommand { get; }
        public ICommand RemoveUserCommand { get; }

        public UserViewModel(LibraryLogicL libraryLogic)
        {
            this.libraryLogic = libraryLogic;
            Users = new ObservableCollection<User>((IEnumerable<User>)libraryLogic.GetUsers()); //

            AddUserCommand = new RelayCommand(AddUser);
            RemoveUserCommand = new RelayCommand(RemoveUser);
        }

        private void AddUser()
        {
            var newUser = new User
            {
                UserId = Guid.NewGuid().ToString(),
                UserName = "NewUser",
                FirstName = "FirstName",
                LastName = "LastName",
                Email = "email@example.com"
            };
            libraryLogic.AddUser(newUser);
            Users.Add(newUser);
        }

        private void RemoveUser()
        {
            if (SelectedUser != null)
            {
                libraryLogic.RemoveUser(SelectedUser.UserId);
                Users.Remove(SelectedUser);
            }
        }
    }
}
