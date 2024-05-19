using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryModelLayer;
using LibraryLogicLayer;
using System.Collections.ObjectModel;
using System.Windows.Input;
namespace LibraryViewModelLayer
{
    public class EventViewModel : ViewModelBase
    {
        private readonly LibraryLogicL libraryLogic;

        public ObservableCollection<Event> Events { get; set; }
        public Event SelectedEvent { get; set; }

        public ICommand AddEventCommand { get; }
        public ICommand RemoveEventCommand { get; }

        public EventViewModel(LibraryLogicL libraryLogic)
        {
            this.libraryLogic = libraryLogic;
            Events = new ObservableCollection<Event>((IEnumerable<Event>)libraryLogic.GetEvents());

            AddEventCommand = new RelayCommand(AddEvent);
            RemoveEventCommand = new RelayCommand(RemoveEvent);
        }

        private void AddEvent()
        {
            var newEvent = new Event
            {
                EventId = "1", 
                EventName = "NewEvent",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,

            };
            libraryLogic.AddEvent(newEvent);
            Events.Add(newEvent);
        }

        private void RemoveEvent()
        {
            if (SelectedEvent != null)
            {
                libraryLogic.RemoveEvent(SelectedEvent.EventId);
                Events.Remove(SelectedEvent);
            }
        }
    }
}
