using System;
using System.ComponentModel;
using Avalonia.Controls;
using ForRR.ViewModels;

namespace ForRR.Views
{
    public partial class DateCheckView : UserControl, INotifyPropertyChanged
    {
        public static DateTime SelectedDate;
        public DateCheckView()
        {
            InitializeComponent();
            DataContext = new DateCheckViewModel();
        }
        private void DatePicker_OnSelectedDateChanged(object? sender, DatePickerSelectedValueChangedEventArgs e)
        {
            if (sender is DatePicker datePicker && datePicker.SelectedDate != null)
            {
                var selectedDateTime = datePicker.SelectedDate.Value.LocalDateTime;
                if (DataContext is DateCheckViewModel viewModel)
                {
                    viewModel.SelectedDate = selectedDateTime;
                    viewModel.CountAge(viewModel.SelectedDate);
                }
            }
        }
        
    }
}