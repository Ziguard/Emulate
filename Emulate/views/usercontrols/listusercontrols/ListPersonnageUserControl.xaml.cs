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

namespace Emulate.views.usercontrols.listusercontrols
{
    /// <summary>
    /// Logique d'interaction pour ListPersonnageUserControl.xaml
    /// </summary>
    public partial class ListPersonnageUserControl : UserControl
    {
        #region attributs
        #endregion

        #region properties
        public ListView ItemsList { get; set; }
        public ObservableCollection<Character> Obs { get; set; }

        #endregion        

        #region constructor
        public ListPersonnageUserControl()
        {
            this.InitializeComponent();
            Obs = new ObservableCollection<Character>();
            this.itemList.ItemsSource = Obs;
            this.ItemsList = this.itemList;
            this.ItemsList.SelectionMode = SelectionMode.Single;
        } 
        #endregion

        public void LoadItems(List<Character> items)
        {
            Obs.Clear();
            foreach (var item in items)
            {
                Obs.Add(item);
            }
        }

        public void AddItem(Character item)
        {
            Obs.Add(item);
        }

        public void RemoveItem(Character item)
        {
            Obs.Remove(item);
        }

    }
}
