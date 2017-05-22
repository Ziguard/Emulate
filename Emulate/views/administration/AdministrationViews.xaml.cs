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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Emulate.views.administration
{
    /// <summary>
    /// Logique d'interaction pour AdministrationViews.xaml
    /// </summary>
    public partial class AdministrationViews : Page
    {
        public AdministrationViews()
        {
            InitializeComponent();
        }

        private void btnPlayer_Click(object sender, RoutedEventArgs e)
        {
            //NavigationWindow window = new NavigationWindow();
            //window.Content = new PersonnageAdmin();
            //window.Show();
        }

        private void btnClasse_Click(object sender, RoutedEventArgs e)
        {
            //NavigationWindow window = new NavigationWindow();
            //window.Content = new ClassesAdmin();
            //window.Show();
        }

        private void btnItems_Click(object sender, RoutedEventArgs e)
        {
            //NavigationWindow window = new NavigationWindow();
            //window.Content = new ItemsAdmin();
            //window.Show();
        }

        private void btnBoss_Click(object sender, RoutedEventArgs e)
        {
            //NavigationWindow window = new NavigationWindow();
            //window.Content = new BossAdmin();
            //window.Show();
        }

        private void btnDonjon_Click(object sender, RoutedEventArgs e)
        {
            //NavigationWindow window = new NavigationWindow();
            //window.Content = new DonjonAdmin();
            //window.Show();
        }

        private void btnPartie_Click(object sender, RoutedEventArgs e)
        {
            //NavigationWindow window = new NavigationWindow();
            //window.Content = new PartyAdmin();
            //window.Show();
        }
    }
}
