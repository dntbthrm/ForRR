using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;

namespace ForRR.Views
{
    public partial class PointDrawView : UserControl
    {
        private Canvas pointDrawer;
        public PointDrawView()
        {
            InitializeComponent();
            pointDrawer = this.FindControl<Canvas>("PointDrawer");
        }
        
        private void CreatePoint(object? sender, PointerPressedEventArgs e)
        {
            if (sender is Canvas canvas)
            {
                var position = e.GetPosition(canvas);
                SetCanvasPosition(dot, position);
            }
        }
        private void SetCanvasPosition(Control control, Point position)
        {
            control.SetValue(Canvas.LeftProperty, position.X);
            control.SetValue(Canvas.TopProperty, position.Y);
            control.Opacity = 1;
        }
    }
}