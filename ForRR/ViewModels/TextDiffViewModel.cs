using System;
using System.ComponentModel;
using ReactiveUI;

namespace ForRR.ViewModels;

public class TextDiffViewModel: ViewModelBase, INotifyPropertyChanged
{
    private string _firstText;
    private string _secondText;
    private string _diffResult;

    public string FirstText
    {
        get => _firstText;
        set => this.RaiseAndSetIfChanged(ref _firstText, value);
    }

    public string SecondText
    {
        get => _secondText;
        set => this.RaiseAndSetIfChanged(ref _secondText, value);
    }

    public string DiffResult
    {
        get => _diffResult;
        set => this.RaiseAndSetIfChanged(ref _diffResult, value);
    }

    public void FindDiffs()
    {
        int minLength = Math.Min(FirstText.Length, SecondText.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (FirstText[i] != SecondText[i])
            {
                DiffResult = $"Первый различный символ на позиции {i + 1}, символ 1: {FirstText[i]}, символ 2: {SecondText[i]}";
                return;
            }
        }

        DiffResult = "Тексты полностью совпадают";
    }
    public TextDiffViewModel(){}
}