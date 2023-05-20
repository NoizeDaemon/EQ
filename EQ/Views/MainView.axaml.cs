using Avalonia.Controls;
using Avalonia.Interactivity;
using LiveChartsCore.SkiaSharpView.Avalonia;

namespace EQ.Views
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();

            Loaded += delegate
            {
                CoordinateSystem1.InvalidateMeasure();
                CoordinateSystem2.InvalidateMeasure();
            };
        }
    }
}