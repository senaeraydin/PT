using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModelLayer
{
    public interface ICatalogItemRepository
    {
        IEnumerable<CatalogItem> GetCatalogItems();
        void AddCatalogItem(CatalogItem item);
        void RemoveCatalogItem(string itemId);
    }
}
