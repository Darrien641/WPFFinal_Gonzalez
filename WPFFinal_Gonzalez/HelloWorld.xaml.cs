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
    /// Interaction logic for HelloWorld.xaml
    /// </summary>
    public partial class HelloWorld : Window
    {
        public HelloWorld()
        {
            InitializeComponent();
        }

        private void GravButn_Click(object sender, RoutedEventArgs e)
        {
            Window Grav = new Gravity();
            this.Close();
            Grav.Show();
        }

        private void RepeatButn_Click(object sender, RoutedEventArgs e)
        {
            Window Main = new MainWindow();
            this.Close();
            Main.Show();
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
