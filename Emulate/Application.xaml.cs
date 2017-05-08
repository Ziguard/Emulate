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
            //Personnage personnage = new Personnage();
            //Boss boss = new Boss();
            //Donjon donjon = new Donjon();

        }

        private void btnDemarrer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdministration_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Administration();
            window.Show();
        }
    }
}
