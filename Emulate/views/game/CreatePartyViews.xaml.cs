using Emulate.viewsmodel;
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

namespace Emulate.views.game
{
    /// <summary>
    /// Logique d'interaction pour PartyAdmin.xaml
    /// </summary>
    public partial class CreatePartyViews : Page
    {
        public CreatePartyViews()
        {
            InitializeComponent();
            this.DataContext = new CreatePartyAdminVM(this);
        }

        //Charger d'un autre VM
        public CreatePartyViews(ChoosePartyAdminVM partyAdminVM)
        {
            InitializeComponent();
            this.DataContext = partyAdminVM;
            partyAdminVM.LoadCreatePartyPage(this);
        }
    }
}
