using Emulate.database;
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

namespace Emulate.views.usercontrols.listusercontrols
{
    /// <summary>
    /// Logique d'interaction pour ListPartyUserControl.xaml
    /// </summary>
    public partial class ListPartyUserControl : UserControl
    {
        public ListView ItemsList { get; set; }
        public ObservableCollection<Party> Obs { get; set; }
        public MySQLManager<Party> partySQLManager;

        public ListPartyUserControl()
        {
            this.InitializeComponent();
            partySQLManager = new MySQLManager<Party>();
            Obs = new ObservableCollection<Party>();
            this.itemList.ItemsSource = Obs;
            this.ItemsList = this.itemList;
            this.ItemsList.SelectionMode = SelectionMode.Single;
        }

        public void LoadItems(List<Party> items)
        {
            Obs.Clear();
            foreach (var item in items)
            {
                Obs.Add(item);
            }
        }
        public void AddItem(Party item)
        {
            Obs.Add(item);
        }

    }
}
