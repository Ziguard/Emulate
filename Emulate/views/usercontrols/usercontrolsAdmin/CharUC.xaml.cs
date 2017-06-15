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
    /// Logique d'interaction pour CharUC.xaml
    /// </summary>
    public partial class CharUC : UserControlBase
    {
        private Character character;

        public Character Character
        {
            get { return character; }
            set { character = value;
                base.OnPropertyChanged("Character");
            }
        }

        public CharUC()
        {
            InitializeComponent();
            base.DataContext = this;
        }
    }
}
