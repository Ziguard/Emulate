using Emulate.entities;
using Emulate.views.administration;
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
using System.Windows.Shapes;

namespace Emulate
{
    /// <summary>
    /// Logique d'interaction pour Administration.xaml
    /// </summary>
    public partial class Administration : Window
    {
        public Administration()
        {
            InitializeComponent();
            Personnage personnage = new Personnage();
        }

        private void btnPlayer_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Content = new PersonnageAdmin();
            window.Show();
        }

        private void btnClasse_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Content = new ClassesAdmin();
            window.Show();
        }

        private void btnItems_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Content = new ItemsAdmin();
            window.Show();
        }

        private void btnBoss_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Content = new BossAdmin();
            window.Show();
        }

        private void btnDonjon_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Content = new DonjonAdmin();
            window.Show();
        }

        private void btnPartie_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Content = new PartyAdmin();
            window.Show();
        }
    }
}
