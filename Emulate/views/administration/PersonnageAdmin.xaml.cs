using Emulate.entities;
using Emulate.viewsmodel;
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

namespace Emulate.views.administration
{
    /// <summary>
    /// Logique d'interaction pour GroupAdmin.xaml
    /// </summary>
    public partial class PersonnageAdmin : Page
    {
        ObservableCollection<Personnage> PersonnageList = new ObservableCollection<Personnage>();

        public PersonnageAdmin()
        {
            InitializeComponent();
            this.DataContext = new PersonnageAdminVM(this);
        }

        public PersonnageAdmin(PersonnageAdmin personnageAdminVM)
        {
            InitializeComponent();
            this.DataContext = personnageAdminVM;
            //empAdminVM.LoadJobAdmin(this);
        }
    }
}
