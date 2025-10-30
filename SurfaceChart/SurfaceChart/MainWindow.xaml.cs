using Syncfusion.UI.Xaml.Charts;
using System.Windows;
using System.Windows.Controls;

namespace SurfaceChart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TypeCombo.SelectedIndex = 0;
        }

        private void TypeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Surface == null || TypeCombo?.SelectedValue is not string name) return;
            Surface.Type = (SurfaceType)Enum.Parse(typeof(SurfaceType), name);
        }
    }
}
