using Emulate.entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Emulate.viewsmodel.administration;

namespace Emulate.views.administration
{
    /// <summary>
    /// Logique d'interaction pour GroupAdmin.xaml
    /// </summary>
    public partial class CharactersAdminV : Page
    {
        public CharactersAdminV()
        {
            InitializeComponent();
            this.DataContext = new CharactersAdminVM(this);
        }

        public CharactersAdminV(PartyAdminVM partyAdminVM)
        {
            InitializeComponent();
            this.DataContext = partyAdminVM;
            partyAdminVM.LoadCharAdminVM(this);
        }

        //public CharactersAdminV(AdministrationAdminVM administrationAdminVM)
        //{
        //    InitializeComponent();
        //    this.DataContext = administrationAdminVM;
        //    administrationAdminVM.LoadCharAdminVM(this);
        //}
    }
}
