using System.ComponentModel;
using ReactiveUI;

namespace ForRR.ViewModels
{

    public class ColorScreenViewModel: ViewModelBase, INotifyPropertyChanged
    {
        private string _redValue = "red";
        private string _blueValue = "blue";
        private string _greenValue = "green";
        private string _colorHex = "#FFFFFF";

        public string RedValue
        {
            get => _redValue;
            set => this.RaiseAndSetIfChanged(ref _redValue, value);
        }
        public string BlueValue
        {
            get => _blueValue;
            set => this.RaiseAndSetIfChanged(ref _blueValue, value);
        }
        public string GreenValue
        {
            get => _greenValue;
            set => this.RaiseAndSetIfChanged(ref _greenValue, value);
        }
        public string ColorHex
        {
            get => _colorHex;
            set => this.RaiseAndSetIfChanged(ref _colorHex, value);
        }

        public void AddColor()
        {
            int r, g, b;
            if (int.TryParse(RedValue, out r) && int.TryParse(BlueValue, out b) && int.TryParse(GreenValue, out g))
            {
                ColorHex = $"#{r:X2}{g:X2}{b:X2}";
            }
            
        }
        public ColorScreenViewModel(){}
    }
}