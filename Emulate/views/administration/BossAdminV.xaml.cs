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
    /// Logique d'interaction pour BossAdmin.xaml
    /// </summary>
    public partial class BossAdminV : Page
    {
        public BossAdminV()
        {
            InitializeComponent();
            this.DataContext = new BossAdminVM(this);
        }

        public BossAdminV(DonjonAdminVM donjonAdminVM)
        {
            InitializeComponent();
            this.DataContext = donjonAdminVM;
            donjonAdminVM.LoadBossAdminVM(this);
        }


    }
}
