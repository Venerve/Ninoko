using Ninoko.Logics;
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
        public readonly NinokoLogics _logics;
        private readonly int _levelEn, _levelJa, _levelEs;
        public UsersPersonalWindow(string LoginBox, int levelEn, int levelJa, int levelEs)
        {
            InitializeComponent();
            _levelEn = levelEn;
            _levelJa = levelJa;
            _levelEs = levelEs;
            switch (_levelEn)
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
            switch (_levelJa)
            {
                case 1:
                    Ja2.IsEnabled = false;
                    Ja3.IsEnabled = false;
                    Ja4.IsEnabled = false;
                    Ja5.IsEnabled = false;
                    break;
                case 2:
                    Ja3.IsEnabled = false;
                    Ja4.IsEnabled = false;
                    Ja5.IsEnabled = false;
                    break;
                case 3:
                    Ja4.IsEnabled = false;
                    Ja5.IsEnabled = false;
                    break;
                case 4:
                    Ja5.IsEnabled = false;
                    break;
                case 5:
                    break;
            }
            switch (_levelEs)
            {
                case 1:
                    Es2.IsEnabled = false;
                    Es3.IsEnabled = false;
                    Es4.IsEnabled = false;
                    Es5.IsEnabled = false;
                    break;
                case 2:
                    Es3.IsEnabled = false;
                    Es4.IsEnabled = false;
                    Es5.IsEnabled = false;
                    break;
                case 3:
                    Es4.IsEnabled = false;
                    Es5.IsEnabled = false;
                    break;
                case 4:
                    Es5.IsEnabled = false;
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
            string name = "En1";
            var window = new Level(name);
            window.ShowDialog();
        }

        private void English2(object sender, RoutedEventArgs e)
        {
            string name = "En2";
            var window = new Level(name);
            window.ShowDialog();
        }

        private void English3(object sender, RoutedEventArgs e)
        {
            string name = "En3";
            var window = new Level(name);
            window.ShowDialog();
        }

        private void English4(object sender, RoutedEventArgs e)
        {
            string name = "En4";
            var window = new Level(name);
            window.ShowDialog();

        }

        private void English5(object sender, RoutedEventArgs e)
        {
            string name = "En5";
            var window = new Level5(name);
            window.ShowDialog();

        }

        //Japanese buttons
        private void Japanese1(object sender, RoutedEventArgs e)
        {
            string name = "Ja1";
            var window = new Level(name);
            window.ShowDialog();
        }

        private void Japanese2(object sender, RoutedEventArgs e)
        {
            string name = "Ja2";
            var window = new Level(name);
            window.ShowDialog();
        }

        private void Japanese3(object sender, RoutedEventArgs e)
        {
            string name = "Ja3";
            var window = new Level(name);
            window.ShowDialog();
        }

        private void Japanese4(object sender, RoutedEventArgs e)
        {
            string name = "Ja4";
            var window = new Level(name);
            window.ShowDialog();

        }

        private void Japanese5(object sender, RoutedEventArgs e)
        {
            string name = "Ja5";
            var window = new Level5(name);
            window.ShowDialog();

        }

        //Spanish buttons
        private void Espanol1(object sender, RoutedEventArgs e)
        {
            string name = "Es1";
            var window = new Level(name);
            window.ShowDialog();
        }

        private void Espanol2(object sender, RoutedEventArgs e)
        {
            string name = "Es2";
            var window = new Level(name);
            window.ShowDialog();
        }

        private void Espanol3(object sender, RoutedEventArgs e)
        {
            string name = "Es3";
            var window = new Level(name);
            window.ShowDialog();
        }

        private void Espanol4(object sender, RoutedEventArgs e)
        {
            string name = "Es4";
            var window = new Level(name);
            window.ShowDialog();

        }

        private void Espanol5(object sender, RoutedEventArgs e)
        {
            string name = "Es5";
            var window = new Level5(name);
            window.ShowDialog();

        }
    }
}
