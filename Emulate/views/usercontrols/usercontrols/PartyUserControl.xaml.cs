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

namespace Emulate.views.usercontrols.usercontrols
{
    /// <summary>
    /// Logique d'interaction pour PartyUserControl.xaml
    /// </summary>
    public partial class PartyUserControl : UserControl
    {
        public PartyUserControl()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            //Affiche l'userControl de creationdePartie
            this.Content = new createPartyUserControl();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            //Get Parti en test si existence personnage
            if (true)
            {
                //Test si existence de donjon en court 
                if (true)
                {
                    //Si oui arriver sur la page du donjon en question
                }
                //SiNon arriver sur la page de lancerment de jeux
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //TODO Delete en base de la partie en question ( getid)
        }
    }
}
