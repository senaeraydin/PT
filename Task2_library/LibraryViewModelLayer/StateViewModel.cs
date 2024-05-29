using LibraryModelLayer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;

namespace LibraryViewModelLayer
{
    public class State : INotifyPropertyChanged
    {
        private static List<State> stateList = new List<State>
        {
            new State { StateId = "1", StateName = "State A", Description = "Description A" },
            new State { StateId = "2", StateName = "State B", Description = "Description B" }
        };

        private string stateId;
        private string stateName;
        private string description;

        public string StateId
        {
            get => stateId;
            set
            {
                stateId = value;
                OnPropertyChanged(nameof(StateId));
            }
        }

        public string StateName
        {
            get => stateName;
            set
            {
                stateName = value;
                OnPropertyChanged(nameof(StateName));
            }
        }

        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Static methods to manipulate state data
        public static List<State> GetStates()
        {
            return stateList;
        }

        public static void AddState(State state)
        {
            stateList.Add(state);
        }

        public static void RemoveState(string stateId)
        {
            var state = stateList.FirstOrDefault(s => s.StateId == stateId);
            if (state != null)
            {
                stateList.Remove(state);
            }
        }
    }
}
