using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDataLayer;

namespace LogicTest
{
    public class MockDataRepository : InterfaceDataLayer
    {
        public List<User> Users { get; set; } = new List<User>();

        public List<CatalogItem> CatalogItems { get; set; } = new List<CatalogItem>();

        public State State { get; set; } = new State();

        public List<Event> Events { get; set; } = new List<Event>();

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void RemoveUser(string userId)
        {
            var userToRemove = Users.Find(u => u.UserId == userId);
            if (userToRemove != null)
            {
                Users.Remove(userToRemove);
            }
        }

        public void AddCatalogItem(CatalogItem catalogItem)
        {
            CatalogItems.Add(catalogItem);
        }

        public void RemoveCatalogItem(string itemId)
        {
            var itemToRemove = CatalogItems.Find(a => a.ItemId == itemId);
            if (itemToRemove != null)
            {
                CatalogItems.Remove(itemToRemove);
            }
        }

        public void AddEvent(Event event_)
        {
            Events.Add(event_);
        }

        public void RemoveEvent(string eventId)
        {
            var eventToRemove = Events.Find(b => b.EventId == eventId);
            if (eventToRemove != null)
            {
                Events.Remove(eventToRemove);
            }
        }

        public void UpdateState(State state)
        {
            State = state;
        }

        public List<User> GetUsers()
        {
            return Users;
        }

        public List<CatalogItem> GetCatalogItems()
        {
            return CatalogItems;
        }

        public State GetState()
        {
            return State;
        }

        public List<Event> GetEvents()
        {
            return Events;
        }
    }
}

