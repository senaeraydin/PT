using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryModelLayer;
using LibraryLogicLayer;
using System.Windows.Input;
using System.Collections.ObjectModel;
namespace LibraryViewModelLayer
{
    public class CatalogItemViewModel : ViewModelBase
    {
        private readonly LibraryLogicL libraryLogic;

        public ObservableCollection<CatalogItem> CatalogItems { get; set; }
        public CatalogItem SelectedCatalogItem { get; set; }

        public ICommand AddCatalogItemCommand { get; }
        public ICommand RemoveCatalogItemCommand { get; }

        public CatalogItemViewModel(LibraryLogicL libraryLogic)
        {
            this.libraryLogic = libraryLogic;
            CatalogItems = new ObservableCollection<CatalogItem>((IEnumerable<CatalogItem>)libraryLogic.GetCatalogItems());

            AddCatalogItemCommand = new RelayCommand(AddCatalogItem);
            RemoveCatalogItemCommand = new RelayCommand(RemoveCatalogItem);
        }

        private void AddCatalogItem()
        {
            var newCatalogItem = new CatalogItem
            {
                ItemId = "1", // Just for demonstration purposes
                Name = "NewItem",
                Description = "NewCategory",
                Price = 10,
                Quantity = 5
            };
            libraryLogic.AddCatalogItem(newCatalogItem);
            CatalogItems.Add(newCatalogItem);
        }

        private void RemoveCatalogItem()
        {
            if (SelectedCatalogItem != null)
            {
                libraryLogic.RemoveCatalogItem(SelectedCatalogItem.ItemId);
                CatalogItems.Remove(SelectedCatalogItem);
            }
        }
    }
}
