using System;
using System.Collections.Generic;
using System.Linq;
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
        public readonly NinokoLogics _logics = new NinokoLogics();
        private int _level;
        public UsersPersonalWindow(string LoginBox, int level)
        {
            InitializeComponent();
            _level = level;
            switch (_level)
            {
                case 1:
                    En2.IsEnabled = false;
                    En3.IsEnabled = false;
                    En4.IsEnabled = false;
                    En5.IsEnabled = false;
                    break;
                case 2:
                    En3.IsEnabled = false;
                    En4.IsEnabled = false;
                    En5.IsEnabled = false;
                    break;
                case 3:
                    En4.IsEnabled = false;
                    En5.IsEnabled = false;
                    break;
                case 4:
                    En5.IsEnabled = false;
                    break;
                case 5:
                    break;


            }

        }

        

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //English buttons
        private void English1(object sender, RoutedEventArgs e)
        {

        }

        private void English2(object sender, RoutedEventArgs e)
        {

        }

        private void English3(object sender, RoutedEventArgs e)
        {

        }

        private void English4(object sender, RoutedEventArgs e)
        {

        }

        private void English5(object sender, RoutedEventArgs e)
        {

        }

        //
    }
}
