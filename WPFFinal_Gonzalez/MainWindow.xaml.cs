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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFFinal_Gonzalez
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
        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GravButn_Click(object sender, RoutedEventArgs e)
        {
            Window Grav = new Gravity();
            this.Close();
            Grav.Show();
        }
        private void Hello_Click(object sender, RoutedEventArgs e)
        {
            Window Hello = new HelloWorld();
            this.Close();
            Hello.Show();
        }
    }
}
