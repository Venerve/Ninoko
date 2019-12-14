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

namespace Ninoko
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

        public string LoginBox { get; set; }

        private void Login(object sender, RoutedEventArgs e)
        {
            //if (loginBox.Text.ToString().In(SmartParkingApp.users.ToString()) & passwordBox.Text.ToString().In(SmartParkingApp.users.ToString()))
            //{
            //    LoginBox = loginBox.Text.ToString();
            //    var window = new ClientPageWindow(LoginBox);
            //    window.ShowDialog();
            //}

        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
