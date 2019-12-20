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
        public readonly NinokoLogics _logics = new NinokoLogics();
        private readonly int _levelEn, _levelJa, _levelEs;
        private readonly Repository _repository = new Repository();
        private readonly string _username;

        public UsersPersonalWindow(string username, int levelEn, int levelJa, int levelEs)
        {
            InitializeComponent();
            _levelEn = levelEn;
            _levelJa = levelJa;
            _levelEs = levelEs;
            _username = username;

            _logics.AvailableButtons(_levelEn, En2, En3, En4, En5);
            _logics.AvailableButtons(_levelJa, Ja2, Ja3, Ja4, Ja5);
            _logics.AvailableButtons(_levelEs, Es2, Es3, Es4, Es5);
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //English buttons
        private void English1(object sender, RoutedEventArgs e)
        {
            string name = "En1";
            var window = new Level(_repository, name, _username);
            window.ShowDialog();
            _logics.AvailableButtons(_levelEn, En2, En3, En4, En5);
        }

        private void English2(object sender, RoutedEventArgs e)
        {
            string name = "En2";
            var window = new Level(_repository, name, _username);
            window.ShowDialog();
            _logics.AvailableButtons(_levelEn, En2, En3, En4, En5);
        }

        private void English3(object sender, RoutedEventArgs e)
        {
            string name = "En3";
            var window = new Level(_repository, name, _username);
            window.ShowDialog();
            _logics.AvailableButtons(_levelEn, En2, En3, En4, En5);
        }

        private void English4(object sender, RoutedEventArgs e)
        {
            string name = "En4";
            var window = new Level(_repository, name, _username);
            window.ShowDialog();
            _logics.AvailableButtons(_levelEn, En2, En3, En4, En5);
        }

        private void English5(object sender, RoutedEventArgs e)
        {
            string name = "En5";
            var window = new Level(_repository, name, _username);
            window.ShowDialog();
            _logics.AvailableButtons(_levelEn, En2, En3, En4, En5);
        }

        //Japanese buttons
        private void Japanese1(object sender, RoutedEventArgs e)
        {
            string name = "Ja1";
            var window = new Level(_repository, name, _username);
            window.ShowDialog();
            _logics.AvailableButtons(_levelJa, Ja2, Ja3, Ja4, Ja5);
        }

        private void Japanese2(object sender, RoutedEventArgs e)
        {
            string name = "Ja2";
            var window = new Level(_repository, name, _username);
            window.ShowDialog();
            _logics.AvailableButtons(_levelJa, Ja2, Ja3, Ja4, Ja5);
        }

        private void Japanese3(object sender, RoutedEventArgs e)
        {
            string name = "Ja3";
            var window = new Level(_repository, name, _username);
            window.ShowDialog();
            _logics.AvailableButtons(_levelJa, Ja2, Ja3, Ja4, Ja5);
        }

        private void Japanese4(object sender, RoutedEventArgs e)
        {
            string name = "Ja4";
            var window = new Level(_repository, name, _username);
            window.ShowDialog();
            _logics.AvailableButtons(_levelJa, Ja2, Ja3, Ja4, Ja5);
        }

        private void Japanese5(object sender, RoutedEventArgs e)
        {
            string name = "Ja5";
            var window = new Level(_repository, name, _username);
            window.ShowDialog();
            _logics.AvailableButtons(_levelJa, Ja2, Ja3, Ja4, Ja5);
        }

        //Spanish buttons
        private void Espanol1(object sender, RoutedEventArgs e)
        {
            string name = "Es1";
            var window = new Level(_repository, name, _username);
            window.ShowDialog();
            _logics.AvailableButtons(_levelEs, Es2, Es3, Es4, Es5);
        }

        private void Espanol2(object sender, RoutedEventArgs e)
        {
            string name = "Es2";
            var window = new Level(_repository, name, _username);
            window.ShowDialog();
            _logics.AvailableButtons(_levelEs, Es2, Es3, Es4, Es5);
        }

        private void Espanol3(object sender, RoutedEventArgs e)
        {
            string name = "Es3";
            var window = new Level(_repository, name, _username);
            window.ShowDialog();
            _logics.AvailableButtons(_levelEs, Es2, Es3, Es4, Es5);
        }

        private void Espanol4(object sender, RoutedEventArgs e)
        {
            string name = "Es4";
            var window = new Level(_repository, name, _username);
            window.ShowDialog();
            _logics.AvailableButtons(_levelEs, Es2, Es3, Es4, Es5);
        }

        private void Espanol5(object sender, RoutedEventArgs e)
        {
            string name = "Es5";
            var window = new Level(_repository, name, _username);
            window.ShowDialog();
            _logics.AvailableButtons(_levelEs, Es2, Es3, Es4, Es5);
        }
    }
}
