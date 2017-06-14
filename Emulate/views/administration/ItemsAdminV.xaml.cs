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
    /// Logique d'interaction pour ItemsAdminV.xaml
    /// </summary>
    public partial class ItemsAdminV : Page
    {
        public ItemsAdminV()
        {
            InitializeComponent();
            this.DataContext = new ItemsAdminVM(this);
        }

        public ItemsAdminV(BossAdminVM bossAdminVM)
        {
            InitializeComponent();
            this.DataContext = bossAdminVM;
            bossAdminVM.LoadItemsBoosAdminVM(this);
        }

        public ItemsAdminV(DonjonAdminVM donjonAdminVM)
        {
            InitializeComponent();
            this.DataContext = donjonAdminVM;
            donjonAdminVM.LoadDonjonAdminVM(this);
        }
    }
}
