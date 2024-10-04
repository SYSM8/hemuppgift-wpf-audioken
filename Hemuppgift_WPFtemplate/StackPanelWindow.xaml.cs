using System.Windows;
using System.Windows.Controls;

namespace Hemuppgift_WPFtemplate
{
    public partial class StackPanelWindow : Window
    {
        public StackPanelWindow()
        {
            InitializeComponent();
        }

        // Ändrar orienteringen för färgade fyrkanter till horisontell för att visa dom i en rad
        private void rbtnHorizontal_Click(object sender, RoutedEventArgs e)
        {

            sqrColors.Orientation = Orientation.Horizontal;
        }

        // Ändrar orienteringen för färgade fyrkanter till vertikal för att visa dom i en kolumn
        private void rbtnVertical_Click(object sender, RoutedEventArgs e)
        {
            sqrColors.Orientation = Orientation.Vertical;
        }
    }
}
