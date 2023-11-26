using System.Collections.ObjectModel;
using System.ComponentModel;
using ReactiveUI;

namespace ForRR.ViewModels
{

    public class MoveItemsViewModel: ViewModelBase, INotifyPropertyChanged
    {
        private ObservableCollection<string> _myList = new ObservableCollection<string> {"Item1", "Item2", "Item3", "Item4", "Item5"};
        private int _sIndex = 1;

        public ObservableCollection<string> MyList
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
                var item = MyList[SIndex];
                var tmp = MyList[SIndex - 1];
                MyList[SIndex - 1] = item;
                MyList[SIndex] = tmp;
            }
        }
        
        public MoveItemsViewModel()
        {}
    }
}