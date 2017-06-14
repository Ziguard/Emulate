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
    public class DonjonAdminVM
    {
        #region DefinitionViews

        private DonjonAdminV donjonAdminV;
        private BossAdminV bossAdminV;
        private ItemsAdminV itemAdminV;

        #endregion

        #region DefinitionEntities

        private Donjon currentDonjon;
        private Boss currentBoss;
        private Items currentItem;
        #endregion

        #region DefinitionManager

        private MySQLBossManager bossManager = new MySQLBossManager();
        private MySQLDonjonManager donjonManager = new MySQLDonjonManager();
        private MySQLManager<Items> itemsManager = new MySQLManager<Items>();

        #endregion


        #region DefinitionLogiqueDonjon

        public DonjonAdminVM(DonjonAdminV donjonAdminViews)
        {
            this.donjonAdminV = donjonAdminViews;
            InitUC();
            InitLUC();
            InitActions();

        }



        private void InitUC()
        {
            currentDonjon = new Donjon();
        }

        private async void InitLUC()
        {
            this.donjonAdminV.LUCDonjon.LoadItems((await donjonManager.Get()).ToList());
        }

        private void InitActions()
        {
            this.donjonAdminV.btnNouveau.Click += BtnNouveau_Click;
            this.donjonAdminV.btnMettreAjour.Click += BtnMettreAjour_Click;
            this.donjonAdminV.btnSupprimer.Click += BtnSupprimer_Click;

            this.donjonAdminV.LUCDonjon.itemList.SelectionChanged += ItemList_SelectionChanged;
            this.donjonAdminV.UCDonjon.btnBoss.Click += BtnBoss_Click;
        }

        private void ItemList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                currentDonjon = (e.AddedItems[0] as Donjon);
                this.donjonAdminV.UCDonjon.Donjon = currentDonjon;
                donjonManager.GetBoss(currentDonjon);
            }
        }

        private void BtnNouveau_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            InitUC();
        }

        private async void BtnMettreAjour_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.donjonAdminV.UCDonjon.Donjon.Id != 0)
            {
                await donjonManager.Update(this.donjonAdminV.UCDonjon.Donjon);
            }
            else
            {
                currentDonjon = this.donjonAdminV.UCDonjon.Donjon;
                await donjonManager.Insert(currentDonjon);
            }
            InitLUC();
        }

        private async void BtnSupprimer_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.donjonAdminV.UCDonjon.Donjon.Id != 0)
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer le Donjon " + this.donjonAdminV.UCDonjon.Donjon.Name + " ?", "Supprimer Donjon", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    this.donjonAdminV.LUCDonjon.Obs.Remove(donjonAdminV.UCDonjon.Donjon);
                    await donjonManager.Delete(donjonAdminV.UCDonjon.Donjon);
                    currentDonjon = new Donjon();
                    this.donjonAdminV.UCDonjon.Donjon = currentDonjon;
                }
            }
            else
            {
                MessageBox.Show("Vous devez selectionner un Donjon", "Supprimer Donjon", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void BtnBoss_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (currentDonjon.Id != 0)
            {
                this.donjonAdminV.NavigationService.Navigate(new BossAdminV(this));
            }
            else
            {
                MessageBox.Show("Vous devez selectionner un donjon pour pouvoir aller a cette page", "Pas de Donjon Selectionner", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        #endregion


        #region DefinitionLogiqueBoss
        internal void LoadBossAdminVM(BossAdminV bossAdminV)
        {
            this.bossAdminV = bossAdminV;
            InitUCBoss();
            InitLUCBoss();
            InitActionsBoss();
        }

        private void InitUCBoss()
        {
            currentDonjon = this.donjonAdminV.UCDonjon.Donjon;
            currentBoss = new Boss();
            this.bossAdminV.UCBoss.Boss = currentBoss;
        }


        private void InitLUCBoss()
        {
            donjonManager.GetBoss(currentDonjon);
            this.bossAdminV.LUCBoss.LoadItems((currentDonjon.ListeBoss).ToList());
        }

        private void InitActionsBoss()
        {
            this.bossAdminV.btnSupprimer.Click += BtnSupprimerBoss_Click;
            this.bossAdminV.btnMettreAjour.Click += BtnMettreAjourBoss_Click;
            this.bossAdminV.btnNouveau.Click += BtnNouveauBoss_Click;
            this.bossAdminV.LUCBoss.ItemsList.SelectionChanged += ItemsList_SelectionChanged;
            this.bossAdminV.UCBoss.btnLoot.Click += BtnLoot_Click;
        }

        private void BtnLoot_Click(object sender, RoutedEventArgs e)
        {
            if (currentBoss.Id != 0)
            {
                this.bossAdminV.NavigationService.Navigate(new ItemsAdminV(this));
            }
            else
            {
                MessageBox.Show("Vous devez selection au moins un boss", "Vous n'avez pas selectionné de boss", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void ItemsList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                currentBoss = (e.AddedItems[0] as Boss);
                this.bossAdminV.UCBoss.Boss = currentBoss;
                bossManager.GetItems(currentBoss);
            }
        }

        private void BtnNouveauBoss_Click(object sender, RoutedEventArgs e)
        {
            InitUCBoss();
        }

        private async void BtnMettreAjourBoss_Click(object sender, RoutedEventArgs e)
        {
            if (this.bossAdminV.UCBoss.Boss.Id != 0)
            {
                currentBoss = this.bossAdminV.UCBoss.Boss;
                await bossManager.Update(currentBoss);
                this.bossAdminV.NavigationService.GoBack();
            }
            else
            {
                currentDonjon = this.donjonAdminV.UCDonjon.Donjon;
                currentDonjon.ListeBoss.Add(this.bossAdminV.UCBoss.Boss);
                await donjonManager.Update(currentDonjon);
                this.bossAdminV.NavigationService.GoBack();
            }
        }

        private async void BtnSupprimerBoss_Click(object sender, RoutedEventArgs e)
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
        #endregion


        #region LogiqueAdminItems

        internal void LoadDonjonAdminVM(ItemsAdminV itemsAdminV)
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
            bossManager.GetItems(currentBoss);
            this.itemAdminV.LUCItems.LoadItems((currentBoss.ListLoot).ToList());

        }

        private void InitActionsItems()
        {
            this.itemAdminV.LUCItems.ItemsList.SelectionChanged += ItemsListItems_SelectionChanged; ;
            this.itemAdminV.btnNouveau.Click += BtnNouveauItems_Click;
            this.itemAdminV.btnMettreAjour.Click += BtnMettreAjourItems_Click;
            this.itemAdminV.btnSupprimer.Click += BtnSupprimerItems_Click;
        }

        private void ItemsListItems_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                currentItem = (e.AddedItems[0] as Items);
                this.itemAdminV.UCItems.Items = currentItem;
            }
        }

        private void BtnNouveauItems_Click(object sender, RoutedEventArgs e)
        {
            InitUCItems();
        }


        /// <summary>
        /// Ajoute un item au boss , donjon selectionner.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnMettreAjourItems_Click(object sender, RoutedEventArgs e)
        {
            if (this.itemAdminV.UCItems.Items.Id != 0)
            {
                currentItem = this.itemAdminV.UCItems.Items;
                await itemsManager.Update(currentItem);
                this.itemAdminV.NavigationService.GoBack();
            }
            else
            {
                currentBoss = this.bossAdminV.UCBoss.Boss;
                currentBoss.ListLoot.Add(this.itemAdminV.UCItems.Items);
                await bossManager.Update(currentBoss);
                this.itemAdminV.NavigationService.GoBack();
            }

            //Code Fonctionnement avec update de la bdd sur le boss
            //if (this.itemAdminV.UCItems.Items.Id != 0)
            //{
            //    currentItem = this.itemAdminV.UCItems.Items;
            //    await itemsManager.Update(currentItem);
            //    this.itemAdminV.NavigationService.GoBack();
            //}
            //else
            //{
            //    currentBoss.ListLoot.Add(this.itemAdminV.UCItems.Items);          
            //    this.itemAdminV.NavigationService.GoBack();
            //}
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
                    await donjonManager.Update(donjonAdminV.UCDonjon.Donjon);
                    InitUCItems();
                }
            }
            else
            {
                MessageBox.Show("Vous devez selectionner un loot", "Supprimer Loot", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        #endregion
    }
}
