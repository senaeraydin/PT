using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataLayer
{
    public class LibraryData : InterfaceDataLayer
    {
        private readonly string connectionString;

        public LibraryData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<User> GetUsers()
        {
            using (var context = new DataLayerClasses1DataContext(connectionString))
            {
                return context.Users.ToList();
            }
        }

        public List<CatalogItem> GetCatalogItems()
        {
            using (var context = new DataLayerClasses1DataContext(connectionString))
            {
                return context.CatalogItems.ToList();
            }
        }

        public List<Event> GetEvents()
        {
            using (var context = new DataLayerClasses1DataContext(connectionString))
            {
                return context.Events.ToList();
            }
        }

        public State GetState(string stateId)
        {
            using (var context = new DataLayerClasses1DataContext(connectionString))
            {
                return context.States.SingleOrDefault(s => s.StateId == stateId);
            }
        }

        public void AddUser(User user)
        {
            using (var context = new DataLayerClasses1DataContext(connectionString))
            {
                context.Users.InsertOnSubmit(user);
                context.SubmitChanges();
            }
        }

        public void RemoveUser(string userId)
        {
            using (var context = new DataLayerClasses1DataContext(connectionString))
            {
                var user = context.Users.SingleOrDefault(u => u.UserId == userId);
                if (user != null)
                {
                    context.Users.DeleteOnSubmit(user);
                    context.SubmitChanges();
                }
            }
        }

        public void AddCatalogItem(CatalogItem catalogItem)
        {
            using (var context = new DataLayerClasses1DataContext(connectionString))
            {
                context.CatalogItems.InsertOnSubmit(catalogItem);
                context.SubmitChanges();
            }
        }

        public void RemoveCatalogItem(string itemId)
        {
            using (var context = new DataLayerClasses1DataContext(connectionString))
            {
                var item = context.CatalogItems.SingleOrDefault(i => i.ItemId == itemId);
                if (item != null)
                {
                    context.CatalogItems.DeleteOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }

        public void AddEvent(Event event_)
        {
            using (var context = new DataLayerClasses1DataContext(connectionString))
            {
                context.Events.InsertOnSubmit(event_);
                context.SubmitChanges();
            }
        }

        public void RemoveEvent(string eventId)
        {
            using (var context = new DataLayerClasses1DataContext(connectionString))
            {
                var event_ = context.Events.SingleOrDefault(e => e.EventId == eventId);
                if (event_ != null)
                {
                    context.Events.DeleteOnSubmit(event_);
                    context.SubmitChanges();
                }
            }
        }

        public void UpdateState(State state)
        {
            using (var context = new DataLayerClasses1DataContext(connectionString))
            {
                var existingState = context.States.SingleOrDefault(s => s.StateId == state.StateId);
                if (existingState != null)
                {
                    existingState.StateName = state.StateName;
                    existingState.Description = state.Description;
                    context.SubmitChanges();
                }
            }
        }
    }
}
