using System.Windows;
using System.Windows.Controls;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for WrapPanelWindow.xaml
    /// </summary>
    public partial class WrapPanelWindow : Window
    {
        public WrapPanelWindow()
        {
            InitializeComponent();
        }

        private void rbtnHorizontal_Click(object sender, RoutedEventArgs e)
        {
            elpsColors.Orientation = Orientation.Horizontal;
        }

        private void rbtnVertical_Click(object sender, RoutedEventArgs e)
        {
            elpsColors.Orientation = Orientation.Vertical;
        }
    }
}
