using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    public partial class DockPanelWindow : Window
    {
        public DockPanelWindow()
        {
            InitializeComponent();
        }

        // Visa bild vid klick på "Center"-knappen
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            imgTrophy.Visibility = Visibility.Visible; // Visa bild
        }
    }
}
