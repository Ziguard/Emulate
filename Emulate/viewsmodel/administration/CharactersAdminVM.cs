using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emulate.views.administration;
using Emulate.entities;
using Emulate.database;
using System.Windows;
using Emulate.database.entitieslinks;

namespace Emulate.viewsmodel.administration
{
    public class CharactersAdminVM
    {

        #region DefinitionViews

        private CharactersAdminV charAdminV;
        private LootAdminV lootAdminV;

        #endregion

        #region DefinitionEntities

        private Character currentChar;
        private Loot currentLoot;
        private Items currentItem;

        #endregion

        #region DefinitionManager

        private MySQLCharacterManager charManager = new MySQLCharacterManager();
        private MySQLItemsManager itemsManager = new MySQLItemsManager();

        private MySQLManager<Loot> lootManager = new MySQLManager<Loot>();


        #endregion


        #region LogiquePersonnageAdmin

        public CharactersAdminVM(CharactersAdminV charAdminViews)
        {
            this.charAdminV = charAdminViews;
            InitUC();
            InitLUC();
            InitCharActions();

        }



        private void InitUC()
        {
            currentChar = new Character();
            this.charAdminV.UCChar.Character = currentChar;
        }

        private async void InitLUC()
        {
            this.charAdminV.LUCChar.LoadItems((await charManager.Get()).ToList());
        }

        private void InitCharActions()
        {
            this.charAdminV.LUCChar.itemList.SelectionChanged += ItemList_SelectionChanged;

            this.charAdminV.btnNouveau.Click += BtnNouveau_Click;
            this.charAdminV.btnMettreAjour.Click += BtnMettreAjour_Click;
            this.charAdminV.btnSupprimer.Click += BtnSupprimer_Click;

            this.charAdminV.UCChar.btnLoot.Click += BtnLoot_Click;
        }

        private void ItemList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            currentChar = (e.AddedItems[0] as Character);
            this.charAdminV.UCChar.Character = currentChar;
        }



        private async void BtnSupprimer_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.charAdminV.UCChar.Character.Id != 0)
            {
                if (true)
                {
                    this.charAdminV.LUCChar.Obs.Remove(charAdminV.UCChar.Character);
                    await charManager.Delete(charAdminV.UCChar.Character);
                    currentChar = new Character();
                    this.charAdminV.UCChar.Character = currentChar;
                }
            }
            else
            {
                MessageBox.Show("Vous devez selectionner un object a supprimer", "Delete Char", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }


        /// <summary>
        /// Sauvegarde l'objet en base ou le met a jour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnMettreAjour_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.charAdminV.UCChar.Character.Id != 0)
            {
                await charManager.Update(this.charAdminV.UCChar.Character);
            }
            else
            {
                await charManager.Insert(this.charAdminV.UCChar.Character);
                this.charAdminV.LUCChar.Obs.Add(this.charAdminV.UCChar.Character);
                this.charAdminV.UCChar.Character = currentChar;
            }
            
        }

        private void BtnNouveau_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            InitUC();
        }

        private void BtnLoot_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.charAdminV.NavigationService.Navigate(new LootAdminV(this));
        }


        #endregion

        internal void LoadLootAdminVM(LootAdminV lootAdminV)
        {
            this.lootAdminV = lootAdminV;
            InitUCLoot();
            InitLUCLoot();
            InitActionsLoot();
        }

        private void InitUCLoot()
        {
            currentChar = this.charAdminV.UCChar.Character;
            currentLoot = new Loot();
            currentLoot.Character = currentChar;
            this.lootAdminV.UCLoot.Loot = currentLoot;
            
        }

        private async void InitLUCLoot()
        {
            charManager.GetLoot(currentChar);
            this.lootAdminV.LUCLoot.LoadItems((currentChar.Equipement).ToList());
            this.lootAdminV.LUCItems.LoadItems((await itemsManager.Get()).ToList());
        }

        private void InitActionsLoot()
        {
            this.lootAdminV.LUCLoot.ItemsList.SelectionChanged += ItemsList_SelectionChanged;
            this.lootAdminV.LUCItems.ItemsList.SelectionChanged += ItemsList_ItemsSelectionChanged;

            this.lootAdminV.btnNouveau.Click += BtnNouveauLoot_Click;
            this.lootAdminV.btnMettreAjour.Click += BtnMettreAjourLoot_Click;
            this.lootAdminV.btnSupprimer.Click += BtnSupprimerLoot_Click;
        }

        private async void BtnMettreAjourLoot_Click(object sender, RoutedEventArgs e)
        {
            if (this.lootAdminV.UCLoot.Loot.Id != 0)
            {
                currentLoot = this.lootAdminV.UCLoot.Loot;
                await lootManager.Update(currentLoot);
                this.lootAdminV.NavigationService.GoBack();
            }
            else
            {
                currentChar.Equipement.Add(this.lootAdminV.UCLoot.Loot);
                await charManager.Update(currentChar);
                this.lootAdminV.NavigationService.GoBack();
            }
        }

        private async void BtnSupprimerLoot_Click(object sender, RoutedEventArgs e)
        {
            if (this.lootAdminV.UCLoot.Loot.Id != 0)
            {
                if (MessageBox.Show("Voulez vous vraiement supprimer l'item " + this.lootAdminV.UCLoot.Loot.Id + " ?", "Supprimer Item", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {

                    this.lootAdminV.LUCLoot.Obs.Remove(lootAdminV.UCLoot.Loot);
                    currentChar.Equipement.Remove(currentLoot);

                    await lootManager.Delete(lootAdminV.UCLoot.Loot);
                    currentLoot = new Loot();
                    this.lootAdminV.UCLoot.Loot = currentLoot;
                    InitUCLoot();
                }
            }
            else
            {
                MessageBox.Show("Vous devez selectionner un object a supprimer", "Supprimer Loot", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void BtnNouveauLoot_Click(object sender, RoutedEventArgs e)
        {
            InitUCLoot();
        }

        private void ItemsList_ItemsSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                currentItem = (e.AddedItems[0] as Items);
                currentLoot.ItemsId = currentItem.Id;
            }
        }

        private void ItemsList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                currentLoot = (e.AddedItems[0] as Loot);
                this.lootAdminV.UCLoot.Loot = currentLoot;
            }
        }
    }
}
