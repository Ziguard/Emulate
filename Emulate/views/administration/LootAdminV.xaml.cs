using Emulate.viewsmodel.administration;
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
    /// Logique d'interaction pour LootAdminV.xaml
    /// </summary>
    public partial class LootAdminV : Page
    {
        public LootAdminV()
        {
            InitializeComponent();
            this.DataContext = new LootAdminVM(this);
        }

        public LootAdminV(PartyAdminVM partyAdminVM)
        {
            InitializeComponent();
            this.DataContext = partyAdminVM;
            partyAdminVM.LoadLootAdminVM(this);
        }

        public LootAdminV(CharactersAdminVM charAdminVM)
        {
            InitializeComponent();
            this.DataContext = charAdminVM;
            charAdminVM.LoadLootAdminVM(this);
        }
    }
}
