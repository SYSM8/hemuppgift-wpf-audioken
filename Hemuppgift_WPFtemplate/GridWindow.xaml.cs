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

        // Hanterar klickhändelsen för btnApply och uppdaterar positionen för btnPosition i gridfältet
        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            // Kontrollerar att båda inmatningarna är siffror mellan 0-4
            if (int.TryParse(txtRow.Text, out int row) && int.TryParse(txtColumn.Text, out int column)
                && row >= 0 && row <= 4 && column >= 0 && column <= 4)
            {
                // Ändrar knappens text till de inmatade koordinaterna
                btnPosition.Content = $"Row {row}, Column {column}";

                // Placerar knappen enligt de inmatade koordinaterna
                Grid.SetRow(btnPosition, row + 1); // Justerar eftersom StackPanel redan ligger i row 0
                Grid.SetColumn(btnPosition, column);

                // Visar knappen i gridfältet
                btnPosition.Visibility = Visibility.Visible;
            }
            else
            {
                // Visar ett felmeddelande vid felaktig inmatning
                MessageBox.Show("Use digits between 0-4 only");
            }
        }
    }
}
