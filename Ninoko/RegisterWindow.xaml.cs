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
using Newtonsoft.Json;
using System.Linq;


namespace Ninoko
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>

    public partial class RegisterWindow : Window
    {

        public readonly NinokoLogics _logics = new NinokoLogics();
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void RegisterClick(object sender, RoutedEventArgs e)
        {
            if ((string.IsNullOrEmpty(usernameBox.Text) | (string.IsNullOrEmpty(passwordBox.Password)) | (string.IsNullOrEmpty(repPasswordBox.Password))))
            {
                MessageBox.Show("Every field should be filled!", "Filling error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (passwordBox.Password != repPasswordBox.Password)
            {
                MessageBox.Show("Passwords don't match!", "Passwords", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            else if (!_logics.users
                .Any(value => value.Username.Contains(usernameBox.Text)))
            {
                _logics.Registration(usernameBox.Text, repPasswordBox.Password);
            }
            else
            {
                MessageBox.Show("User already exists. Please, write other username or click 'Login'.", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

        }
    }
}
