﻿using Emulate.entities;
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
    /// Logique d'interaction pour ListItemsUserControl.xaml
    /// </summary>
    public partial class ListItemsUserControl : UserControl
    {
        #region attributs
        #endregion

        #region properties
        public ListView ItemsList { get; set; }
        public ObservableCollection<Items> Obs { get; set; }
        #endregion

        #region constructor
        public ListItemsUserControl()
        {
            this.InitializeComponent();
            Obs = new ObservableCollection<Items>();
            this.itemList.ItemsSource = Obs;
            this.ItemsList = this.itemList;
            this.ItemsList.SelectionMode = SelectionMode.Single;
        }

        #endregion

        #region methods

        /// <summary>
        /// Current list for User items.
        /// </summary>
        public void LoadItems(List<Items> items)
        {
            Obs.Clear();
            foreach (var item in items)
            {
                Obs.Add(item);
            }
        }

        public void AddItem(Items item)
        {
            Obs.Add(item);
        }

        public void RemoveItem(Items item)
        {
            Obs.Remove(item);
        }

        #endregion
    }
}
