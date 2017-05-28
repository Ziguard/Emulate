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

namespace Emulate.views.usercontrols.usercontrolsAdmin
{
    /// <summary>
    /// Logique d'interaction pour PartyUC.xaml
    /// </summary>
    public partial class PartyUC : UserControlBase
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

        public PartyUC()
        {
            InitializeComponent();
            base.DataContext = this;
        }
    }
}
