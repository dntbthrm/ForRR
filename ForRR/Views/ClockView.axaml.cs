using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Threading;

namespace ForRR.Views
{
    public partial class ClockView : UserControl
    {
        private DispatcherTimer timer;

        public ClockView()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            int hour = currentTime.Hour % 12;
            int minute = currentTime.Minute;
            int second = currentTime.Second;

            double hourAngle = hour * 30 + minute * 0.5;
            double minuteAngle = minute * 6;
            double secondAngle = second * 6;

            hourHand.RenderTransformOrigin = new RelativePoint(1, 1, RelativeUnit.Relative);
            hourHand.RenderTransform = new RotateTransform(hourAngle, 0, 0);

            minuteHand.RenderTransformOrigin = new RelativePoint(1, 1, RelativeUnit.Relative);
            minuteHand.RenderTransform = new RotateTransform(minuteAngle, 0, 0);

            secondHand.RenderTransformOrigin = new RelativePoint(1, 1, RelativeUnit.Relative);
            secondHand.RenderTransform = new RotateTransform(secondAngle, 0, 0);
            
        }
        
    }
}