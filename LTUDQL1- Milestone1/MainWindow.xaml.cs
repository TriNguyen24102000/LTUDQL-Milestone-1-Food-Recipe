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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LTUDQL1__Milestone1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void usernameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            usernamePlaceholder.Visibility = Visibility.Hidden;
        }

        private void usernameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (usernameTextBox.Text.Length == 0)
            {
                usernamePlaceholder.Visibility = Visibility.Visible;
            }
        }

        private void passwordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            passwordPlaceholder.Visibility = Visibility.Hidden;
        }

        private void passwordTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (passwordTextBox.Password.Length == 0)
            {
                passwordPlaceholder.Visibility = Visibility.Visible;
            }
        }
        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            var scr = new SplashScreen();
            scr.Show();
            this.Close();
        }
    }
}
