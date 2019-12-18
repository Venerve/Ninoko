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

namespace Ninoko
{
    /// <summary>
    /// Interaction logic for UsersPersonalWindow.xaml
    /// </summary>
    public partial class UsersPersonalWindow : Window
    {
        public UsersPersonalWindow(string LoginBox)
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
