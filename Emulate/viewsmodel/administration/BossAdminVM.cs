using Emulate.database;
using Emulate.database.entitieslinks;
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
    public class BossAdminVM
    {
        #region DefinitionViews

        private BossAdminV bossAdminV;
        private ItemsAdminV itemAdminV;

        #endregion

        #region DefinitionEntities

        private Boss currentBoss;
        private Items currentItem;

        #endregion

        #region DefinitionManager

        private MySQLBossManager bossManager = new MySQLBossManager();
        private MySQLItemsManager itemsManager = new MySQLItemsManager();

        #endregion


        #region LogiqueAdminBoss

        public BossAdminVM(BossAdminV bossAdminViews)
        {
            this.bossAdminV = bossAdminViews;
            InitUC();
            InitLUC();
            InitActions();
        }

        /// <summary>
        /// Reset L'uc et l'object boss
        /// </summary>
        private void InitUC()
        {
            currentBoss = new Boss();
            this.bossAdminV.UCBoss.Boss = currentBoss;
        }

        /// <summary>
        /// Charge la liste des boss de la BDD
        /// </summary>
        private async void InitLUC()
        {
            this.bossAdminV.LUCBoss.LoadItems((await bossManager.Get()).ToList());
        }


        private void InitActions()
        {
            this.bossAdminV.btnNouveau.Click += BtnNouveau_Click;
            this.bossAdminV.btnMettreAjour.Click += BtnMettreAjour_Click;
            this.bossAdminV.btnSupprimer.Click += BtnSupprimer_Click; ;
            this.bossAdminV.LUCBoss.itemList.SelectionChanged += ItemList_SelectionChanged;
            this.bossAdminV.UCBoss.btnLoot.Click += BtnLoot_Click;
        }

        /// <summary>
        /// Charge la liste des loot du boss selectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLoot_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (currentBoss.Id != 0)
            {
                this.bossAdminV.NavigationService.Navigate(new ItemsAdminV(this));
            }
            else
            {
                MessageBox.Show("You must select a boss to go to its Items page... ", "No Boss selected", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private async void BtnSupprimer_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.bossAdminV.UCBoss.Boss.Id != 0)
            {
                if (MessageBox.Show("Voulez vous vraiement supprimer le boss " + this.bossAdminV.UCBoss.Boss.Name + " ?", "Supprimer Boss", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    this.bossAdminV.LUCBoss.Obs.Remove(bossAdminV.UCBoss.Boss);
                    await bossManager.Delete(bossAdminV.UCBoss.Boss);
                    currentBoss = new Boss();
                    this.bossAdminV.UCBoss.Boss = currentBoss;
                }
            }
            else
            {
                MessageBox.Show("Vous devez selectionner un boss", "Supprimer Boss", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private async void BtnMettreAjour_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.bossAdminV.UCBoss.Boss.Id != 0)
            {
                await bossManager.Update(this.bossAdminV.UCBoss.Boss);
            }
            else
            {
                currentBoss = this.bossAdminV.UCBoss.Boss;
                await bossManager.Insert(currentBoss);
                this.bossAdminV.UCBoss.Boss = currentBoss;
            }
            InitLUC();
        }

        private void BtnNouveau_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            InitUC();
        }


        private void ItemList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                currentBoss = (e.AddedItems[0] as Boss);
                this.bossAdminV.UCBoss.Boss = currentBoss;
                bossManager.GetItems(currentBoss);
            }
        }
        #endregion


        #region LogiqueAdminItems

        internal void LoadItemsBoosAdminVM(ItemsAdminV itemsAdminV)
        {
            this.itemAdminV = itemsAdminV;
            InitUCItems();
            InitLUCItems();
            InitActionsItems();
        }

        private void InitUCItems()
        {
            currentItem = new Items();
            this.itemAdminV.UCItems.Items = currentItem;
        }

        private void InitLUCItems()
        {
            //this.itemAdminV.LUCItems.LoadItems((await itemsManager.Get()).ToList());
            bossManager.GetItems(currentBoss);
            this.itemAdminV.LUCItems.LoadItems((currentBoss.ListLoot).ToList());

        }

        private void InitActionsItems()
        {
            this.itemAdminV.LUCItems.ItemsList.SelectionChanged += ItemsList_SelectionChanged;
            this.itemAdminV.btnNouveau.Click += BtnNouveauItems_Click;
            this.itemAdminV.btnMettreAjour.Click += BtnMettreAjourItems_Click;
            this.itemAdminV.btnSupprimer.Click += BtnSupprimerItems_Click;
        }

        private async void BtnSupprimerItems_Click(object sender, RoutedEventArgs e)
        {
            currentItem = this.itemAdminV.UCItems.Items;

            if (this.itemAdminV.UCItems.Items.Id != 0)
            {
                if (MessageBox.Show("Voulez vous vraiement supprimer le loot suivant " + this.itemAdminV.UCItems.Items.Name + " ?", "Supprimer Loot", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    this.itemAdminV.LUCItems.Obs.Remove(this.itemAdminV.UCItems.Items);
                    currentBoss.ListLoot.Remove(currentItem);
                    await bossManager.Update(bossAdminV.UCBoss.Boss);
                    InitUCItems();
                }
            }
            else
            {
                MessageBox.Show("Vous devez selectionner un loot", "Supprimer Loot", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private async void BtnMettreAjourItems_Click(object sender, RoutedEventArgs e)
        {
            if (this.itemAdminV.UCItems.Items.Id != 0)
            {
                await bossManager.Update(this.bossAdminV.UCBoss.Boss);
                this.itemAdminV.NavigationService.GoBack();
            }
            else
            {
                currentBoss.ListLoot.Add(this.itemAdminV.UCItems.Items);
                await bossManager.Update(currentBoss);
                this.itemAdminV.NavigationService.GoBack();
            }

        }

        private void BtnNouveauItems_Click(object sender, RoutedEventArgs e)
        {
            InitUCItems();
        }

        private void ItemsList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                currentItem = (e.AddedItems[0] as Items);
                this.itemAdminV.UCItems.Items = currentItem;
            }
        }
        #endregion
    }
}
