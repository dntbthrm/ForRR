using Avalonia.Controls;
using ForRR.ViewModels;

namespace ForRR.Views
{
    public partial class WordPartSearchView : UserControl
    {
        public WordPartSearchView()
        {
            InitializeComponent();
            
        }

        private void SearchBox_Changed(object? sender, TextChangedEventArgs e)
        {
            if (sender is TextBox txt && txt.Text != null)
            {
                var to_search = SearchTextBox.Text;
                
                if (DataContext is WordPartSearchViewModel viewModel)
                {
                    viewModel.TextToSearch = to_search;
                    viewModel.FindWords();
                    
                }
            }
        }
    }
}