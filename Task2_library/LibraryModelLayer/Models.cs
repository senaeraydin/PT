using System;
using System.ComponentModel;
namespace LibraryModelLayer
{
    public class User : INotifyPropertyChanged
    {
        private static List<User> userList = new List<User>
        {
            new User { UserId = "1", UserName = "jdoe", FirstName = "John", LastName = "Doe", Email = "jdoe@example.com" },
            new User { UserId = "2", UserName = "asmith", FirstName = "Anna", LastName = "Smith", Email = "asmith@example.com" }
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

    public class CatalogItem : INotifyPropertyChanged
    {
        private static List<CatalogItem> catalogItemList = new List<CatalogItem>
        {
            new CatalogItem { ItemId = "1", Name = "Book A", Description = "Description A", Price = 10.99m, Quantity = 5 },
            new CatalogItem { ItemId = "2", Name = "Book B", Description = "Description B", Price = 15.99m, Quantity = 3 }
        };

        private string itemId;
        private string name;
        private string description;
        private decimal price;
        private int quantity;

        public string ItemId
        {
            get => itemId;
            set
            {
                itemId = value;
                OnPropertyChanged(nameof(ItemId));
            }
        }

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public decimal Price
        {
            get => price;
            set
            {
                price = value;
                OnPropertyChanged(nameof(Price));
            }
        }

        public int Quantity
        {
            get => quantity;
            set
            {
                quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Static methods to manipulate catalog item data
        public static List<CatalogItem> GetCatalogItems()
        {
            return catalogItemList;
        }

        public static void AddCatalogItem(CatalogItem item)
        {
            catalogItemList.Add(item);
        }

        public static void RemoveCatalogItem(string itemId)
        {
            var item = catalogItemList.FirstOrDefault(ci => ci.ItemId == itemId);
            if (item != null)
            {
                catalogItemList.Remove(item);
            }
        }
    }

    public class Event : INotifyPropertyChanged
    {
        private static List<Event> eventList = new List<Event>
        {
            new Event { EventId = "1", EventName = "Event A", StartTime = DateTime.Now.AddHours(-1), EndTime = DateTime.Now.AddHours(1) },
            new Event { EventId = "2", EventName = "Event B", StartTime = DateTime.Now.AddDays(1), EndTime = DateTime.Now.AddDays(1).AddHours(2) }
        };

        private string eventId;
        private string eventName;
        private DateTime startTime;
        private DateTime endTime;

        public string EventId
        {
            get => eventId;
            set
            {
                eventId = value;
                OnPropertyChanged(nameof(EventId));
            }
        }

        public string EventName
        {
            get => eventName;
            set
            {
                eventName = value;
                OnPropertyChanged(nameof(EventName));
            }
        }

        public DateTime StartTime
        {
            get => startTime;
            set
            {
                startTime = value;
                OnPropertyChanged(nameof(StartTime));
            }
        }

        public DateTime EndTime
        {
            get => endTime;
            set
            {
                endTime = value;
                OnPropertyChanged(nameof(EndTime));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Static methods to manipulate event data
        public static List<Event> GetEvents()
        {
            return eventList;
        }

        public static void AddEvent(Event eventItem)
        {
            eventList.Add(eventItem);
        }

        public static void RemoveEvent(string eventId)
        {
            var eventItem = eventList.FirstOrDefault(e => e.EventId == eventId);
            if (eventItem != null)
            {
                eventList.Remove(eventItem);
            }
        }
    }

    public class State : INotifyPropertyChanged
    {
        private static List<State> stateList = new List<State>
        {
            new State { StateId = "1", StateName = "Available", Description = "Item is available" },
            new State { StateId = "2", StateName = "CheckedOut", Description = "Item is checked out" }
        };

        private string stateId;
        private string stateName;
        private string description;

        public string StateId
        {
            get => stateId;
            set
            {
                stateId = value;
                OnPropertyChanged(nameof(StateId));
            }
        }

        public string StateName
        {
            get => stateName;
            set
            {
                stateName = value;
                OnPropertyChanged(nameof(StateName));
            }
        }

        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Static methods to manipulate state data
        public static List<State> GetStates()
        {
            return stateList;
        }

        public static void AddState(State state)
        {
            stateList.Add(state);
        }

        public static void RemoveState(string stateId)
        {
            var state = stateList.FirstOrDefault(s => s.StateId == stateId);
            if (state != null)
            {
                stateList.Remove(state);
            }
        }
    }
}
