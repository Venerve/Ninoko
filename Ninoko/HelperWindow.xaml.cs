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
    /// Interaction logic for HelperWindow.xaml
    /// </summary>
    public partial class HelperWindow : Window
    {
        public HelperWindow(int errorType)
        {
            InitializeComponent();
            switch (errorType)
            {
                case 1:
                    errorBox.Text = null;
                    errorBox.Text = "passwords don't match";
                    break;
                case 2:
                    errorBox.Text = null;
                    errorBox.Text = "wrong username or login";
                    break;
                case 3:
                    errorBox.Text = null;
                    errorBox.Text = "user with this username already exists";
                    break;
            }
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

