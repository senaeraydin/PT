namespace LibraryDataLayer
{
    public interface InterfaceDataLayer
    {
        List<User> GetUsers();
        List<CatalogItem> GetCatalogItems();
        List<Event> GetEvents();
        State GetState(string stateId);
        void AddUser(User user);
        void RemoveUser(string userId);
        void AddCatalogItem(CatalogItem catalogItem);
        void RemoveCatalogItem(string itemId);
        void AddEvent(Event event_);
        void RemoveEvent(string eventId);
        void UpdateState(State state);
    }
}
