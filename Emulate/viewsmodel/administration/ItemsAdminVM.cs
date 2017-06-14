using Emulate.database;
using Emulate.entities;
using Emulate.views.administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Emulate.viewsmodel.administration
{
    public class ItemsAdminVM
    {
        private ItemsAdminV itemsAdminV;
        private MySQLManager<Items> itemsManager = new MySQLManager<Items>();
        private Items currentItems;


        public ItemsAdminVM(ItemsAdminV itemsAdminViews)
        {
            this.itemsAdminV = itemsAdminViews;
            InitUC();
            InitLUC();
            InitCharActions();
        }

        private void InitUC()
        {
            currentItems = new Items();
            this.itemsAdminV.UCItems.Items = currentItems;
        }

        private async void InitLUC()
        {
            this.itemsAdminV.LUCItems.LoadItems((await itemsManager.Get()).ToList());
        }

        private void InitCharActions()
        {
            this.itemsAdminV.LUCItems.ItemsList.SelectionChanged += ItemsList_SelectionChanged;

            this.itemsAdminV.btnNouveau.Click += BtnNouveau_Click;
            this.itemsAdminV.btnMettreAjour.Click += BtnMettreAjour_Click;
            this.itemsAdminV.btnSupprimer.Click += BtnSupprimer_Click;

        }

        private async void BtnSupprimer_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.itemsAdminV.UCItems.Items.Id != 0)
            {
                if (MessageBox.Show("Voulez vous vraiement supprimer l'item " + this.itemsAdminV.UCItems.Items.Name + " ?", "Supprimer Item", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    this.itemsAdminV.LUCItems.Obs.Remove(itemsAdminV.UCItems.Items);
                    await itemsManager.Delete(itemsAdminV.UCItems.Items);
                    currentItems = new Items();
                    this.itemsAdminV.UCItems.Items = currentItems;
                }
            }
            else
            {
                MessageBox.Show("Vous devez selectionner un object a supprimer", "Supprimer Item", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private async void BtnMettreAjour_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.itemsAdminV.UCItems.Items.Id != 0)
            {
                await itemsManager.Update(this.itemsAdminV.UCItems.Items);
            }
            else
            {
                await itemsManager.Insert(this.itemsAdminV.UCItems.Items);
                this.itemsAdminV.UCItems.Items = currentItems;
            }
        }

        private void BtnNouveau_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            InitUC();
        }

        private void ItemsList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                currentItems = (e.AddedItems[0] as Items);
                this.itemsAdminV.UCItems.Items = currentItems;
            }
        }
    }
}
