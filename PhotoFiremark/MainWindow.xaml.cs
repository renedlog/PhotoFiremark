﻿using PhotoFiremark.Models;
using PhotoFiremark.Views.Pages;
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

namespace PhotoFiremark
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainPage());
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            try
            {
                MainFrame.MarginFadeInAnimation(new Thickness(20, 0, 0, 0), new Thickness(0), TimeSpan.FromMilliseconds(500));
            }
            catch { }
        }
    }
}
