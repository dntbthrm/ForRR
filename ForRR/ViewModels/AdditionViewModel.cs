using System.ComponentModel;
using ReactiveUI;

namespace ForRR.ViewModels;

public class AdditionViewModel: ViewModelBase, INotifyPropertyChanged
{
    private string _firstValue;
    private string _secondValue;
    private string _result;

    public string FirstValue
    {
        get => _firstValue;
        set => this.RaiseAndSetIfChanged(ref _firstValue, value);
    }

    public string SecondValue
    {
        get => _secondValue;
        set => this.RaiseAndSetIfChanged(ref _secondValue, value);
    }

    public string Result
    {
        get => _result;
        set => this.RaiseAndSetIfChanged(ref _result, value);
    }

    public void GetAdditionResult()
    {
        if (FirstValue != null && SecondValue != null)
        {
            int a, b;
            int.TryParse(FirstValue, out a);
            int.TryParse(SecondValue, out b);
            if (int.TryParse(FirstValue, out a) && int.TryParse(SecondValue, out b))
            {
                Result = (a + b).ToString();
            }
        }
    }
    public AdditionViewModel(){}
    
}