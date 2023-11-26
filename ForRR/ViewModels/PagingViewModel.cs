using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ForRR.ViewModels
{ 
    public class PagingViewModel: ViewModelBase, INotifyPropertyChanged
    {
        //когда меняется текущая страничка, ловим Property Change, чтобы заново загузить элементы вместе с этим
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _currentPage = 1;
        private const int ElementAmount = 5;
        private List<string> ItemList = new List<string>{"Item1", "Item2", "Item3", "Item4", "Item5", "Item6", "Item7", "Item8", "Item9", "Item10"};
        
        public int CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value;
                LoadItems();
                OnPropertyChanged(nameof(CurrentPage));
            }
        }
        
        public void GoNext()
        {
            if (CurrentPage * ElementAmount < ItemList.Count)
            {
                CurrentPage++;
            }
        }

        
        public void GoBack()
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
            }
        }
        
        //Кусок всего списка, доступный для отображения
        public ObservableCollection<string> PageItems { get; set; } = new ObservableCollection<string>();
        private void LoadItems()
        {
            int startIndex = (CurrentPage - 1) * ElementAmount;
            int count = ElementAmount;
            PageItems.Clear();
            for (int i = startIndex; i < startIndex + count && i < ItemList.Count; i++)
            {
                PageItems.Add(ItemList[i]);
            }
        }
        
        public PagingViewModel()
        {
            LoadItems();
        }
    }
}