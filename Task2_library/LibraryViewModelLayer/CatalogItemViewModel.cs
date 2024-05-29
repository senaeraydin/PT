using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryModelLayer;

using System.Windows.Input;
using System.Collections.ObjectModel;
namespace LibraryViewModelLayer
{
    public class CatalogItemViewModel : ViewModelBase
    {
        public ObservableCollection<CatalogItem> CatalogItems { get; set; }
        public CatalogItem SelectedCatalogItem { get; set; }

        public ICommand AddCatalogItemCommand { get; }
        public ICommand RemoveCatalogItemCommand { get; }

        public CatalogItemViewModel()
        {
            CatalogItems = new ObservableCollection<CatalogItem>(CatalogItem.GetCatalogItems());

            AddCatalogItemCommand = new RelayCommand(AddCatalogItem);
            RemoveCatalogItemCommand = new RelayCommand(RemoveCatalogItem);
        }

        private void AddCatalogItem()
        {
            var newCatalogItem = new CatalogItem
            {
                ItemId = "1",
                Name = "NewItem",
                Description = "NewCategory",
                Price = 10,
                Quantity = 5
            };
            CatalogItem.AddCatalogItem(newCatalogItem);
            CatalogItems.Add(newCatalogItem);
        }

        private void RemoveCatalogItem()
        {
            if (SelectedCatalogItem != null)
            {
                CatalogItem.RemoveCatalogItem(SelectedCatalogItem.ItemId);
                CatalogItems.Remove(SelectedCatalogItem);
            }
        }
    }
}
