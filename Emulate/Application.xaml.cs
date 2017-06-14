using Emulate.views.administration;
using Emulate.entities;
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
using Emulate.views.game;
using Emulate.viewsmodel;
using Emulate.database;

namespace Emulate
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class Application : Window
    {
        public Application()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Demarrage du jeux
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDemarrer_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            window.Content = new ChoosePartyViews();
            window.Show();
        }

        /// <summary>
        /// Partie Administration du jeux
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdministration_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            window.Content = new AdministrationViews();
            window.Show();        
        }
    }
}
