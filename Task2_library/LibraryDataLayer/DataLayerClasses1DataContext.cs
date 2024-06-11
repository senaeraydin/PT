namespace LibraryDataLayer
{//
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class DataLayerClasses1DataContext
    {
        
        public List<CatalogItem> GetAllCatalogItems()
        {
            var query = from ci in this.CatalogItems
                        select ci;
            return query.ToList();
        }

        
        public CatalogItem GetCatalogItemById(string itemId)
        {
            var query = from ci in this.CatalogItems
                        where ci.ItemId == itemId
                        select ci;
            return query.FirstOrDefault();
        }

        
        public void AddCatalogItem(CatalogItem item)
        {
            this.CatalogItems.InsertOnSubmit(item);
            this.SubmitChanges();
        }

       
      
        public void DeleteCatalogItem(string itemId)
        {
            var query = from ci in this.CatalogItems
                        where ci.ItemId == itemId
                        select ci;

            var item = query.FirstOrDefault();
            if (item != null)
            {
                this.CatalogItems.DeleteOnSubmit(item);
                this.SubmitChanges();
            }
        }

       
    }
}

namespace LibraryDataLayer
{
    public partial class CatalogItem
    {
        
    }

    public partial class Event
    {
      
    }

    public partial class State
    {
        
    }

    public partial class User
    {
        
    }
}
