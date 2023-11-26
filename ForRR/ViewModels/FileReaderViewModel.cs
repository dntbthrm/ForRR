using System.ComponentModel;
using System.IO;
using System.Text;
using ReactiveUI;

// /Users/tatiana/CLionProjects/compMath1/1.txt например это
namespace ForRR.ViewModels
{
    public class FileReaderViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private string _filePath;
        private string _fileText;
        
        public string FilePath
        {
            get => _filePath;
            set => this.RaiseAndSetIfChanged(ref _filePath, value);
        }

        public string FileText
        {
            get => _fileText;
            set => this.RaiseAndSetIfChanged(ref _fileText, value);
        }

        public void ReadMyFile()
        {
            FileText = File.Exists(FilePath) ? File.ReadAllText(FilePath, Encoding.ASCII) : "Такого файла нет";
        }
        public FileReaderViewModel(){}
        
    }
}