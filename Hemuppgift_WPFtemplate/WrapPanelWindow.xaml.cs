using System.Windows;
using System.Windows.Controls;

namespace Hemuppgift_WPFtemplate
{
    public partial class WrapPanelWindow : Window
    {
        public WrapPanelWindow()
        {
            InitializeComponent();
        }

        // Ändrar orienteringen för färgade cirklar till horisontell för att visa dom i en rad
        private void rbtnHorizontal_Click(object sender, RoutedEventArgs e)
        {
            elpsColors.Orientation = Orientation.Horizontal;
        }

        // Ändrar orienteringen för färgade cirklar till vertikal för att visa dom i en rad
        private void rbtnVertical_Click(object sender, RoutedEventArgs e)
        {
            elpsColors.Orientation = Orientation.Vertical;
        }
    }
}
