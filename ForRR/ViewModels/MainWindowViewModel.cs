using System.ComponentModel;
using ForRR.Services;
namespace ForRR.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            ImageReader = new ImageReaderViewModel();
        }
        public ImageReaderViewModel ImageReader { get; }
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
   
//поиск слов
/*public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
   {
   public MainWindowViewModel()
   {
   WordPart = new WordPartSearchViewModel();
   }
   public WordPartSearchViewModel WordPart { get; }
   
   }*/
   
//сложение чисел 
/*public MainWindowViewModel()
   {
   Addition = new AdditionViewModel();
   }
   public AdditionViewModel Addition{ get; }*/
   
//чтение из файла 
/*public MainWindowViewModel()
   {
   FileReader = new FileReaderViewModel();
   }
   public FileReaderViewModel FileReader{ get; }*/
   
// различия текстов
/* public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
   {
   public MainWindowViewModel()
   {
   TextDiff = new TextDiffViewModel();
   }
   public TextDiffViewModel TextDiff{ get; }
   
   }*/ 
// счетчик слов
/* public MainWindowViewModel()
   {
   CountWords = new CountWordsViewModel();
   }
   public CountWordsViewModel CountWords { get; }*/
   
// рисование точки
/*public MainWindowViewModel()
   {
   PointDraw = new PointDrawViewModel();
   }
   public PointDrawViewModel PointDraw { get; }*/