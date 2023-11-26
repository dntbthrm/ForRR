using System.ComponentModel;
using ForRR.Services;
namespace ForRR.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            WordPart = new WordPartSearchViewModel();
        }
        public WordPartSearchViewModel WordPart { get; }
        
    }
}


//список дел
/*public MainWindowViewModel()
   {
   var service = new ToDoListService();
   ToDoList = new ToDoListViewModel(service.GetItems());
   
   }
   
   public ToDoListViewModel ToDoList { get; }*/
   
//проверка возраста
/* public MainWindowViewModel()
   {
   DateCheck = new DateCheckViewModel();
   }
   public DateCheckViewModel DateCheck { get; } */
   
//часы
/*public MainWindowViewModel()
   {
   Clock = new ClockViewModel();
   }
   public ClockViewModel Clock { get; }*/