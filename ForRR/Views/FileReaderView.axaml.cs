using Avalonia.Controls;
using ForRR.ViewModels;

namespace ForRR.Views
{
    public partial class FileReaderView : UserControl
    {
        public FileReaderView()
        {
            InitializeComponent();
        }

        private void FilePath_Changed(object? sender, TextChangedEventArgs e)
        {
            if (sender is TextBox txt && txt.Text != null)
            {
                var file_path = FileInput.Text;
                
                if (DataContext is FileReaderViewModel viewModel)
                {
                    viewModel.FilePath = file_path;
                    viewModel.ReadMyFile();
                    
                }
            }
        }
    }
}


