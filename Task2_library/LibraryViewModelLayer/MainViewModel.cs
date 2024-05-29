
using LibraryModelLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryViewModelLayer
{
    public class MainViewModel : ViewModelBase
    {
        
        public EventViewModel EventVM { get; }
       
        public CatalogItemViewModel CatalogItemVM { get; }

        public ObservableCollection<Event> Events => EventVM.Events;
        
        public ObservableCollection<CatalogItem> CatalogItems => CatalogItemVM.CatalogItems;

        
        public Event SelectedEvent
        {
            get => EventVM.SelectedEvent;
            set => EventVM.SelectedEvent = value;
        }

        

        public CatalogItem SelectedCatalogItem
        {
            get => CatalogItemVM.SelectedCatalogItem;
            set => CatalogItemVM.SelectedCatalogItem = value;
        }


        public ICommand AddEventCommand => EventVM.AddEventCommand;
        public ICommand RemoveEventCommand => EventVM.RemoveEventCommand;

       

        public ICommand AddCatalogItemCommand => CatalogItemVM.AddCatalogItemCommand;
        public ICommand RemoveCatalogItemCommand => CatalogItemVM.RemoveCatalogItemCommand;

        public MainViewModel()
        {
           
            EventVM = new EventViewModel();
          
            CatalogItemVM = new CatalogItemViewModel();
        }
    }
}
