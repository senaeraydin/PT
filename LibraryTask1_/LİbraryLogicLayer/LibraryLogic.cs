using LibraryDataLayer;

namespace LİbraryLogicLayer
{
    public class LibraryLogic
    {
        private readonly LibraryData libraryData;

        public LibraryLogic(LibraryData libraryData_)
        {
            this.libraryData = libraryData_;
        }

        public void AddUser(User user)
        {

            if (libraryData.Users == null)
            {
                libraryData.Users = new List<User>();
            }

            libraryData.Users.Add(user);
        }

        public void RemoveUser(string userId)
        {
            var removedUser = libraryData.Users.Find(u => u.UserId == userId);
            if (removedUser != null)
            {
                libraryData.Users.Remove(removedUser);
            }
        }

        public void AddCatalogItem(CatalogItem catalogItem)
        {
            libraryData.CatalogItems.Add(catalogItem);
        }

        public void RemoveCatalogItem(string ItemId)
        {
            var removedItem = libraryData.CatalogItems.Find(a => a.ItemId == ItemId);
            if (removedItem != null)
            {
                libraryData.CatalogItems.Remove(removedItem);
            }
        }

        public void AddEvent(Event event_)
        {
            libraryData.Events.Add(event_);
        }
        public void RemoveEvent(string eventId)
        {
            var removedEvent = libraryData.Events.Find(b => b.EventId == eventId);
            if (removedEvent != null)
            {
                libraryData.Events.Remove(removedEvent);
            }
        }


        public void UpdateState(State state)
        {
            libraryData.State = state;
        }

        public List<User> GetUsers()
        {
            return libraryData.Users;
        }

        public List<CatalogItem> GetCatalogItems()
        {
            return libraryData.CatalogItems;
        }

        public State GetState()
        {
            return libraryData.State;
        }

        public List<Event> GetEvents()
        {
            return libraryData.Events;
        }
    }
}
