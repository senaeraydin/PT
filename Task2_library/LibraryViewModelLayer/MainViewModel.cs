using LibraryLogicLayer;
using LibraryModelLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryViewModelLayer
{
    public class MainViewModel : ViewModelBase
    {
        public UserViewModel UserVM { get; }
        public EventViewModel EventVM { get; }
        public StateViewModel StateVM { get; }
        public CatalogItemViewModel CatalogItemVM { get; }

        public ObservableCollection<User> Users => UserVM.Users;
        public ObservableCollection<Event> Events => EventVM.Events;
        public ObservableCollection<State> States => StateVM.States;
        public ObservableCollection<CatalogItem> CatalogItems => CatalogItemVM.CatalogItems;

        public User SelectedUser
        {
            get => UserVM.SelectedUser;
            set => UserVM.SelectedUser = value;
        }

        public Event SelectedEvent
        {
            get => EventVM.SelectedEvent;
            set => EventVM.SelectedEvent = value;
        }

        public State SelectedState
        {
            get => StateVM.SelectedState;
            set => StateVM.SelectedState = value;
        }

        public CatalogItem SelectedCatalogItem
        {
            get => CatalogItemVM.SelectedCatalogItem;
            set => CatalogItemVM.SelectedCatalogItem = value;
        }

        public ICommand AddUserCommand => UserVM.AddUserCommand;
        public ICommand RemoveUserCommand => UserVM.RemoveUserCommand;

        public ICommand AddEventCommand => EventVM.AddEventCommand;
        public ICommand RemoveEventCommand => EventVM.RemoveEventCommand;

        public ICommand AddStateCommand => StateVM.AddStateCommand;
        public ICommand RemoveStateCommand => StateVM.RemoveStateCommand;

        public ICommand AddCatalogItemCommand => CatalogItemVM.AddCatalogItemCommand;
        public ICommand RemoveCatalogItemCommand => CatalogItemVM.RemoveCatalogItemCommand;

        public MainViewModel()
        {
            var dataLayer = new LibraryDataLayer.LibraryData("your_connection_string");
            var logicLayer = new LibraryLogicL(dataLayer);

            UserVM = new UserViewModel(logicLayer);
            EventVM = new EventViewModel(logicLayer);
            StateVM = new StateViewModel(logicLayer);
            CatalogItemVM = new CatalogItemViewModel(logicLayer);
        }
    }
}
