using System.ComponentModel;
using ForRR.Services;
namespace ForRR.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            DateCheck = new DateCheckViewModel();
        }
        public DateCheckViewModel DateCheck { get; }
    }
}


//список дел
/*public MainWindowViewModel()
   {
   var service = new ToDoListService();
   ToDoList = new ToDoListViewModel(service.GetItems());
   
   }
   
   public ToDoListViewModel ToDoList { get; }*/