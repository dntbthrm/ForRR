using Avalonia.Controls;
using Avalonia.Input;

namespace ForRR.Views
{
    public partial class PhoneView : UserControl
    {
        public PhoneView()
        {
            InitializeComponent();
        }

        private void KeyChecker(object? sender, KeyEventArgs e)
        {
            if (sender is TextBox txt)
            {
                string text = txt.Text;
                if (!text.StartsWith('+'))
                {
                    txt.Text = "+";
                    txt.CaretIndex = 1;
                }
            }
        }
        private void LetterChecker(object? sender, TextChangedEventArgs e)
        {
            if (sender is TextBox txt && txt.Text.Length > 1)
            {
                string text = txt.Text;
                char sym = text[text.Length - 1];
                var h = char.IsNumber(sym);
                if (!char.IsNumber(sym))
                {
                    txt.Text = text.Remove(text.Length - 1);
                }
            }
        }
        
    }
    
}

