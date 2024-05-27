using LibraryDataLayer;
using System.Collections.Generic;
namespace LibraryLogicLayer
{
    public class LibraryLogicL
    {  //LibraryLogicL
        private readonly InterfaceDataLayer dataLayer;

        public LibraryLogicL(InterfaceDataLayer dataLayer)
        {
            this.dataLayer = dataLayer;
        }

        public List<User> GetUsers() => dataLayer.GetUsers();
        public List<CatalogItem> GetCatalogItems() => dataLayer.GetCatalogItems();
        public List<Event> GetEvents() => dataLayer.GetEvents();
        public State GetState(string stateId) => dataLayer.GetState(stateId);

        public void AddUser(User user) => dataLayer.AddUser(user);
        public void RemoveUser(string userId) => dataLayer.RemoveUser(userId);
        public void AddCatalogItem(CatalogItem catalogItem) => dataLayer.AddCatalogItem(catalogItem);
        public void RemoveCatalogItem(string itemId) => dataLayer.RemoveCatalogItem(itemId);
        public void AddEvent(Event event_) => dataLayer.AddEvent(event_);
        public void RemoveEvent(string eventId) => dataLayer.RemoveEvent(eventId);
        public void UpdateState(State state) => dataLayer.UpdateState(state);

        public void AddUser(global::LibraryModelLayer.User newUser)
        {
            throw new NotImplementedException();
        }

        public void AddCatalogItem(LibraryModelLayer.CatalogItem newCatalogItem)
        {
            throw new NotImplementedException();
        }

        public void AddEvent(LibraryModelLayer.Event newEvent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LibraryModelLayer.State> GetStates()
        {
            throw new NotImplementedException();
        }

        public void AddState(LibraryModelLayer.State newState)
        {
            throw new NotImplementedException();
        }

        public void RemoveState(string stateId)
        {
            throw new NotImplementedException();
        }
    }
}
