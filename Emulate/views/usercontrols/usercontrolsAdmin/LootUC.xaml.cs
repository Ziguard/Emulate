using Emulate.database;
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
    /// Logique d'interaction pour LootUC.xaml
    /// </summary>
    public partial class LootUC : UserControlBase
    {
        private Loot loot;

        public Loot Loot
        {
            get { return loot; }
            set
            {
                loot = value;
                base.OnPropertyChanged("Loot");
            }
        }

        public LootUC()
        {
            InitializeComponent();
            base.DataContext = this;
        }
    }
}
