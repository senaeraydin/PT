using LibraryModelLayer;
using LibraryLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace LibraryViewModelLayer
{
    public class StateViewModel : ViewModelBase
    {
        private readonly LibraryLogicL libraryLogic;

        public ObservableCollection<State> States { get; set; }
        public State SelectedState { get; set; }

        public ICommand AddStateCommand { get; }
        public ICommand RemoveStateCommand { get; }

        public StateViewModel(LibraryLogicL libraryLogic)
        {
            this.libraryLogic = libraryLogic;
            States = new ObservableCollection<State>(libraryLogic.GetStates());

            AddStateCommand = new RelayCommand(AddState);
            RemoveStateCommand = new RelayCommand(RemoveState);
        }

        private void AddState()
        {
            var newState = new State
            {
                StateId = Guid.NewGuid().ToString(),
                StateName = "NewState",
                Description = "NewDescription"
            };
            libraryLogic.AddState(newState);
            States.Add(newState);
        }

        private void RemoveState()
        {
            if (SelectedState != null)
            {
                libraryLogic.RemoveState(SelectedState.StateId);
                States.Remove(SelectedState);
            }
        }
    }
}
