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

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            var window = new MainWindow();
            window.ShowDialog();
        }

        private void RegisterClick(object sender, RoutedEventArgs e)
        {

            if (passwordBox != repPasswordBox)
            {
                MessageBox.Show("Password don't match!", "Passwords", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if ((string.IsNullOrEmpty(userphoneBox.Text) | (string.IsNullOrEmpty(passwordBox.Password) | (string.IsNullOrEmpty(repPasswordBox.Password))
            {
                MessageBox.Show("Error! Every field should be filled!", "Filling error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!_logics.users
                .Any(value => value.UserPhone.Contains(userphoneBox.Text)))
            {
                _logics.Registration(userphoneBox.Text, repPasswordBox.Password);
            }
            else
            {
                MessageBox.Show("You've aleady registrated. Please, enter 'Login' page.", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

        }
    }
}
