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

namespace Emulate.views.usercontrols.usercontrols
{
    /// <summary>
    /// Logique d'interaction pour PartyUserControl.xaml
    /// </summary>
    public partial class PartyUserControl : UserControlBase
    {

        private Party party;

        public Party Party
        {
            get { return party; }
            set
            {
                party = value;
                base.OnPropertyChanged("Party");
            }
        }

        public PartyUserControl()
        {
            InitializeComponent();
            base.DataContext = this;
        }

        //private void btnStart_Click(object sender, RoutedEventArgs e)
        //{
        //    //Get Parti en test si existence personnage
        //    if (true)
        //    {
        //        //Test si existence de donjon en court 
        //        if (true)
        //        {
        //            //Si oui arriver sur la page du donjon en question
        //        }
        //        //SiNon arriver sur la page de lancerment de jeux
        //    }
        //}

        //private void btnDelete_Click(object sender, RoutedEventArgs e)
        //{
        //    //TODO Delete en base de la partie en question ( getid)
        //}
    }
}
