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
using Emulate.viewsmodel;

namespace Emulate.views.game
{
    /// <summary>
    /// Logique d'interaction pour DonjonStartViews.xaml
    /// </summary>
    public partial class DonjonStartViews : Page
    {
        private ChoosePartyAdminVM choosePartyAdminVM;

        public DonjonStartViews()
        {
            InitializeComponent();
        }

        public DonjonStartViews(ChoosePartyAdminVM choosePartyAdminVM)
        {
            InitializeComponent();
            this.DataContext = choosePartyAdminVM;
            choosePartyAdminVM.LoadDonjonStartPage(this);

        }
    }
}
