using ReactiveUI;
using System;
using System.ComponentModel;

namespace ForRR.ViewModels
{
    public class DateCheckViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private DateTime _selectedDate;
        private string _ageResult;
        
        public DateTime SelectedDate
        {
            get => _selectedDate;
            set => this.RaiseAndSetIfChanged(ref _selectedDate, value);
        }
        public string AgeResult
        {
            get => _ageResult;
            set => this.RaiseAndSetIfChanged(ref _ageResult, value);
        }

        public void CountAge(DateTime Birth)
        {
            int age = DateTime.Now.Year - Birth.Year;
            if (DateTime.Now.Month < Birth.Month || (DateTime.Now.Month == Birth.Month && DateTime.Now.Day < Birth.Day))
            {
                age--;
            }

            AgeResult = age >= 18 ? $"Совершеннолетний: {age}" : $"Несовершеннолетний: {age}";
        }
        
        public DateCheckViewModel()
        {}
        
    }
}