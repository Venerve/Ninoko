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
using System.Security.Cryptography;
//using Ninoko.Logics;
//using Newtonsoft.Json;


namespace Ninoko
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public readonly NinokoLogics _logics = new NinokoLogics();
        public MainWindow()
        {
            InitializeComponent();
        }

        public string LoginBox { get; set; }

        private void Login(object sender, RoutedEventArgs e)
        {
            if ((string.IsNullOrEmpty(logUserPhoneBox.Text) | (string.IsNullOrEmpty(logPasswordBox.Password))))
            {
                MessageBox.Show("Error! Every field should be filled!", "Filling error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (_logics.users
                .Any(value => value.UserPhone.Contains(logUserPhoneBox.Text)))
            {
                LoginBox = logUserPhoneBox.Text.ToString();

                var window = new UsersPersonalWindow(LoginBox);
                window.ShowDialog();
            }
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            var window = new RegisterWindow();
            window.ShowDialog();
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
