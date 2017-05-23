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

namespace Emulate.views.usercontrols.usercontrols
{
    /// <summary>
    /// Logique d'interaction pour DonjonUserControl.xaml
    /// </summary>
    public partial class DonjonUserControl : UserControlBase
    {
        private Donjon donjon;

        public Donjon Donjon
        {
            get { return donjon; }
            set { donjon = value;
                base.OnPropertyChanged("Donjon");
            }

        }

        public DonjonUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
