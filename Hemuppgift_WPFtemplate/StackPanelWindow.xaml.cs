using System.Windows;
using System.Windows.Controls;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for StackPanelWindow.xaml
    /// </summary>
    public partial class StackPanelWindow : Window
    {
        public StackPanelWindow()
        {
            InitializeComponent();
        }

        // Ändrar orienteringen för sqrColors till horisontellt
        private void rbtnHorizontal_Click(object sender, RoutedEventArgs e)
        {
            sqrColors.Orientation = Orientation.Horizontal;
        }

        // Ändrar orienteringen för sqrColors till vertikalt
        private void rbtnVertical_Click(object sender, RoutedEventArgs e)
        {
            sqrColors.Orientation = Orientation.Vertical;
        }
    }
}
