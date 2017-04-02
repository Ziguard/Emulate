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

namespace Emulate.views.administration
{
    /// <summary>
    /// Logique d'interaction pour GroupAdmin.xaml
    /// </summary>
    public partial class GroupAdmin : Page
    {
        public GroupAdmin()
        {
            InitializeComponent();
            this.DataContext = new GroupAdminVM(this);
        }

        public GroupAdmin(GroupAdminVM groupAdminVM)
        {
            InitializeComponent();
            this.DataContext = groupAdminVM;
            groupAdminVM.LoadPersonnageAdmin(this);
        }
    }
}
