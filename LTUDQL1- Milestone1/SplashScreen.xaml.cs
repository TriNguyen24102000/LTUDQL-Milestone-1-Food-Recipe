﻿using System;
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
using System.Windows.Threading;

namespace LTUDQL1__Milestone1
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        DispatcherTimer dT = new DispatcherTimer();
        public SplashScreen()
        {
            InitializeComponent();
            dT.Tick += new EventHandler(dt_Tick);
            dT.Interval = new TimeSpan(0, 0, 2);
            dT.Start();
        }
        private void dt_Tick(object sender, EventArgs e)
        {
            var scr = new HomeScreen();
            scr.Show();
            dT.Stop();
            this.Close();
        }
        private void checkBox(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Do not show this dialog when start ", " ", MessageBoxButton.YesNo, MessageBoxImage.Information);
            //var scr = new HomeScreen();
            this.Hide();
            //scr.ShowDialog();
            //this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
