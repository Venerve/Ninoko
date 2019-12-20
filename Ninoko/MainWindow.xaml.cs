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

        private void Login(object sender, RoutedEventArgs e)
        {
            if ((string.IsNullOrEmpty(logUsernameBox.Text) | (string.IsNullOrEmpty(logPasswordBox.Password))))
            {
                MessageBox.Show("Every field should be filled!", "Filling error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if ((_logics.users
                .Any(value => value.Username.Equals(logUsernameBox.Text))) && 
                (_logics.users
                .Any(value => value.Password.Equals(logPasswordBox.Password))))
            {
                var levelEn = _logics.GetLevel(logUsernameBox.Text).Item1;
                var levelJa = _logics.GetLevel(logUsernameBox.Text).Item2;
                var levelEs = _logics.GetLevel(logUsernameBox.Text).Item3;
                var window = new UsersPersonalWindow(logUsernameBox.Text, levelEn, levelJa, levelEs);
                window.ShowDialog();
            }
            else
            {
                MessageBox.Show("Uncorrect username or/and password", "User not found", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
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
