using System.Windows;
using System.Windows.Controls;

namespace Hemuppgift_WPFtemplate
{
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        // Hanterar klick på "Apply" och uppdaterar btnPosition i grid
        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            // Kontrollerar att båda inmatningarna är siffror mellan 0-4
            if (int.TryParse(txtRow.Text, out int row) && int.TryParse(txtColumn.Text, out int column)
                && row >= 0 && row <= 3 && column >= 0 && column <= 3)
            {
                // Uppdaterar knappens text med koordinaterna
                btnPosition.Content = $"Row {row}, Column {column}";

                // Placerar knappen enligt koordinaterna
                Grid.SetRow(btnPosition, row + 1); // Justerar eftersom StackPanel redan ligger i row 0
                Grid.SetColumn(btnPosition, column);
            }
            else
            {
                // Visar felmeddelande vid felaktig inmatning
                MessageBox.Show("Use digits between 0-3 only");
            }
        }
    }
}
