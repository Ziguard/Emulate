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
    /// Logique d'interaction pour ItemUC.xaml
    /// </summary>
    public partial class ItemUC : UserControlBase
    {
        private Items items;

        public Items Items
        {
            get { return items; }
            set
            {
                items = value;
                base.OnPropertyChanged("Items");
            }
        }

        public ItemUC()
        {
            InitializeComponent();
            base.DataContext = this;
        }
    }
}
