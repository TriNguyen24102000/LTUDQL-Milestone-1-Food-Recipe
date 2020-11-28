using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LTUDQL1__Milestone1
{
    /// <summary>
    /// Interaction logic for HomeScreen.xaml
    /// </summary>
    public partial class HomeScreen : Fluent.RibbonWindow
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void BackstageTabItem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void searchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            searchHintTextBlock.Visibility = Visibility.Hidden;
        }

        private void searchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (searchTextBox.Text.Length == 0)
            {
                searchHintTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void pagingComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var scr = new Add();
            scr.ShowDialog();
        }
    }
}
