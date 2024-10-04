﻿using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Öppnar fönstret för GridWindow
        private void btnGrid_Click(object sender, RoutedEventArgs e)
        {
            GridWindow gridWindow = new GridWindow(); // Skapar ett nytt objekt av fönstret
            gridWindow.Show(); // Öppnar fönster
        }

        // Öppnar fönster för StackPanelWindow
        private void btnStackPanel_Click(object sender, RoutedEventArgs e)
        {
            StackPanelWindow stackPanelWindow = new StackPanelWindow(); // Skapar ett nytt objekt av fönstret
            stackPanelWindow.Show(); // Öppnar fönster
        }

        // Öppnar fönster för WrapPanelWindow
        private void btnWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            WrapPanelWindow wrapPanelWindow = new WrapPanelWindow(); // Skapar ett nytt objekt av fönstret
            wrapPanelWindow.Show(); // Öppnar fönster
        }

        private void btnDockPanel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}