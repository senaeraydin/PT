using System;
using System.ComponentModel;
namespace LibraryModelLayer
{
    public class User : INotifyPropertyChanged
    {
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
    }

    public class CatalogItem : INotifyPropertyChanged
    {
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

        
    }

    public class Event : INotifyPropertyChanged
    {
        private string eventId;
        private string eventName;
        private DateTime startTime;
        private DateTime endTime;
        private string stateId;
        private string userId;

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

        public string StateId
        {
            get => stateId;
            set
            {
                stateId = value;
                OnPropertyChanged(nameof(StateId));
            }
        }

        public string UserId
        {
            get => userId;
            set
            {
                userId = value;
                OnPropertyChanged(nameof(UserId));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class State : INotifyPropertyChanged
    {
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
    }
}
