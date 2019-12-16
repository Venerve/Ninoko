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
//using Ninoko.Logics;
//using Newtonsoft.Json;
using System.Linq;


namespace Ninoko
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    static class Extensions
    {
        public static bool In<T>(this T item, params T[] items)
        {
            if (items == null)
                throw new ArgumentNullException("items");
            return items.Contains(item);
        }
    }

    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void Registration(object sender, RoutedEventArgs e)
        {
            if (passwordBox != repPasswordBox)
            {
                //var window = new HelperWindow((int)NinokoLogics.ErrorType.PasswordsDontMatch);
                //window.ShowDialog();
            }
            //if (userameBox.Text.In(NinokoLogics.users.ToString()))
            //{

            //}
            else
            {

            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
