using System;
using System.ComponentModel;
using System.Timers;

namespace ForRR.ViewModels
{
    public class ClockViewModel : INotifyPropertyChanged
    {
        private double _hourHandAngle;
        private double _minuteHandAngle;
        private double _secondHandAngle;

        public double HourHandAngle
        {
            get => _hourHandAngle;
            set
            {
                if (_hourHandAngle != value)
                {
                    _hourHandAngle = value;
                    OnPropertyChanged(nameof(HourHandAngle));
                }
            }
        }

        public double MinuteHandAngle
        {
            get => _minuteHandAngle;
            set
            {
                if (_minuteHandAngle != value)
                {
                    _minuteHandAngle = value;
                    OnPropertyChanged(nameof(MinuteHandAngle));
                }
            }
        }

        public double SecondHandAngle
        {
            get => _secondHandAngle;
            set
            {
                if (_secondHandAngle != value)
                {
                    _secondHandAngle = value;
                    OnPropertyChanged(nameof(SecondHandAngle));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ClockViewModel()
        {
            var timer = new Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            int hour = currentTime.Hour % 12;
            int minute = currentTime.Minute;
            int second = currentTime.Second;

            HourHandAngle = hour * 30 + minute * 0.5;
            MinuteHandAngle = minute * 6;
            SecondHandAngle = second * 6;
        }
    }
}
