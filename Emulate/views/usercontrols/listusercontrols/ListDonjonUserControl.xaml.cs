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
using Emulate.database;
using Emulate.entities;

namespace Emulate.views.usercontrols
{
    /// <summary>
    /// Logique d'interaction pour ListAddressUserControl.xaml
    /// </summary>
    public partial class ListDonjonUserControl : UserControl
    {
        #region attributs
        #endregion

        #region properties
        public ListView ItemsList { get; set; }
        public ObservableCollection<Donjon> Obs { get; set; }
        #endregion

        #region constructor
        public ListDonjonUserControl()
        {
            this.InitializeComponent();
            Obs = new ObservableCollection<Donjon>();
            this.itemList.ItemsSource = Obs;
            this.ItemsList = this.itemList;
            this.ItemsList.SelectionMode = SelectionMode.Single;
        }

        #endregion

        #region methods
        

        /// <summary>
        /// Current list for User items.
        /// </summary>
        public void LoadItems(List<Donjon> items)
        {
            Obs.Clear();
            foreach (var item in items)
            {
                Obs.Add(item);
            }
        }

        public void AddItem(Donjon item)
        {
            Obs.Add(item);
        }

        public void RemoveItem(Donjon item)
        {
            Obs.Remove(item);
        }
        #endregion

        #region events
        #endregion
    }
}
