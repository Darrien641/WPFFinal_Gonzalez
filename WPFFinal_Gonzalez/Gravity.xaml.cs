using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFFinal_Gonzalez
{
    /// <summary>
    /// Interaction logic for Gravity.xaml
    /// </summary>
    public partial class Gravity : Window
    {
        public Gravity()
        {
            InitializeComponent();
        }

        private void Main_Click(object sender, RoutedEventArgs e)
        {
            Window main = new MainWindow();
            this.Close();
            main.Show();
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Hello_Click(object sender, RoutedEventArgs e)
        {
            Window Hello = new HelloWorld();
            this.Close();
            Hello.Show();
        }
    }
}
