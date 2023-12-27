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

namespace SamokatWPF
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void FromMenuToProfile_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Profile());

        }

        private void FromMenuToMain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Main());
        }

        private void FromMenuToPromo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Promo());

        }

        private void FromMenuToBalance_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Balance());

        }

        private void FromMenuToRent_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Rent());

        }
    }
}
