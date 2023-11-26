using System;
using System.Collections.Generic;
using System.ComponentModel;
using ReactiveUI;

namespace ForRR.ViewModels
{

    public class MoveItemsViewModel: ViewModelBase, INotifyPropertyChanged
    {
        private List<string> _myList = new List<String> {"Item1", "Item2", "Item3", "Item4", "Item5"};
        private int _sIndex = 1;

        public List<string> MyList
        {
            get => _myList;
            set => this.RaiseAndSetIfChanged(ref _myList, value);
        }

        public int SIndex
        {
            get => _sIndex;
            set => this.RaiseAndSetIfChanged(ref _sIndex, value);
        }

        public void MoveUp()
        {
            if (SIndex > 0 && SIndex < MyList.Count)
            {
                List<string> copied = new List<string> (_myList);
                var item = copied[SIndex];
                var tmp = copied[SIndex - 1];
                copied[SIndex - 1] = item;
                copied[SIndex] = tmp;
                MyList = copied;
            }
        }
        
        public MoveItemsViewModel()
        {}
    }
}