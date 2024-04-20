using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataLayer
{
    public interface InterfaceDataLayer
    {
        public List<User> Users { get; set; }
        public List<CatalogItem> CatalogItems { get; set; }
        public State State { get; set; }
        public List<Event> Events { get; set; }

        public void AddUser(User user);
        public void RemoveUser(string userId);
        public void AddCatalogItem(CatalogItem catalogItem);
        public void RemoveCatalogItem(string ItemId);
        public void AddEvent(Event event_);
        public void RemoveEvent(string eventId);
        public void UpdateState(State state);
        public List<User> GetUsers();
        public List<CatalogItem> GetCatalogItems();
        public State GetState();
        public List<Event> GetEvents();
    }
}
