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
        private readonly ICatalogItemRepository _catalogItemRepository;

        public ObservableCollection<CatalogItem> CatalogItems { get; set; }
        public CatalogItem SelectedCatalogItem { get; set; }

        public ICommand AddCatalogItemCommand { get; }
        public ICommand RemoveCatalogItemCommand { get; }

        public CatalogItemViewModel(ICatalogItemRepository catalogItemRepository)
        {
            _catalogItemRepository = catalogItemRepository;

            CatalogItems = new ObservableCollection<CatalogItem>(_catalogItemRepository.GetCatalogItems());

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
            _catalogItemRepository.AddCatalogItem(newCatalogItem);
            CatalogItems.Add(newCatalogItem);
        }

        private void RemoveCatalogItem()
        {
            if (SelectedCatalogItem != null)
            {
                _catalogItemRepository.RemoveCatalogItem(SelectedCatalogItem.ItemId);
                CatalogItems.Remove(SelectedCatalogItem);
            }
        }
    }
}

