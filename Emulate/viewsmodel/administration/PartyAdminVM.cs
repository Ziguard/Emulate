using Emulate.database;
using Emulate.database.entitieslinks;
using Emulate.entities;
using Emulate.views.administration;
using Emulate.views.usercontrols.listusercontrols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Emulate.viewsmodel.administration
{
    public class PartyAdminVM
    {
        #region DefinitionViews

        private PartyAdminV partyAdminV;
        private CharactersAdminV charAdminV;
        private LootAdminV lootAdminV;

        #endregion

        #region DefinitionEntities

        private Party currentParty;
        private Character currentChar;
        private Items currentItem;
        private Loot currentLoot;


        #endregion

        #region DefinitionManager

        private MySQLPartyManager partyManager = new MySQLPartyManager();
        private MySQLLootManager lootManager = new MySQLLootManager();
        private MySQLItemsManager itemsManager = new MySQLItemsManager();
        private MySQLBossManager bossManager = new MySQLBossManager();
        private MySQLCharacterManager charManager = new MySQLCharacterManager();

        #endregion

        #region LogiquePourAdminParty
        public PartyAdminVM(PartyAdminV partyAdminViews)
        {
            this.partyAdminV = partyAdminViews;
            InitUC();
            InitLUC();
            InitPartyACtions();

        }

        private void InitUC()
        {
            currentParty = new Party();
            this.partyAdminV.UCParty.Party = currentParty;
        }

        private async void InitLUC()
        {
            this.partyAdminV.LUCParty.LoadItems((await partyManager.Get()).ToList());
        }

        private void InitPartyACtions()
        {
            this.partyAdminV.LUCParty.ItemsList.SelectionChanged += ItemsList_SelectionChanged; ;

            this.partyAdminV.btnNew.Click += BtnNew_Click;
            this.partyAdminV.btnUpdate.Click += BtnUpdate_Click;
            this.partyAdminV.btnDelete.Click += BtnDelete_Click;

            this.partyAdminV.UCParty.buttonPersonnage.Click += ButtonPersonnage_Click;
            this.partyAdminV.UCParty.buttonBag.Click += ButtonBag_Click;
        }



        private void ItemsList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            currentParty = (e.AddedItems[0] as Party);
            this.partyAdminV.UCParty.Party = currentParty;
        }

        private void BtnNew_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            InitUC();
        }

        private async void BtnUpdate_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.partyAdminV.UCParty.Party.Id != 0)
            {
                await partyManager.Update(this.partyAdminV.UCParty.Party);
            }
            else
            {
                await partyManager.Insert(this.partyAdminV.UCParty.Party);
                this.partyAdminV.LUCParty.Obs.Add(this.partyAdminV.UCParty.Party);
                this.partyAdminV.UCParty.Party = currentParty;
            }
        }

        private async void BtnDelete_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.partyAdminV.UCParty.Party.Id != 0)
            {
                if (true)
                {
                    this.partyAdminV.LUCParty.Obs.Remove(partyAdminV.UCParty.Party);
                    await partyManager.Delete(partyAdminV.UCParty.Party);
                    currentParty = new Party();
                    this.partyAdminV.UCParty.Party = currentParty;
                }
            }
            else
            {
                MessageBox.Show("Vous devez selectionner un object a supprimer", "Delete Party", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void ButtonPersonnage_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            partyManager.GetGroupe(currentParty);
            this.partyAdminV.NavigationService.Navigate(new CharactersAdminV(this));
        }


        private void ButtonBag_Click(object sender, RoutedEventArgs e)
        {
            if (currentParty.Id == 0)
            {
                if (MessageBox.Show("Vous devez sauvegarde la partie " + this.partyAdminV.UCParty.Party.Name + " avant de pouvoir acceder au sac, Souhaitez vous le faire ? ", "Save Party", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    BtnUpdate_Click(sender, e);
                    this.partyAdminV.NavigationService.Navigate(new LootAdminV(this));
                }
            }
            else
            {
                this.partyAdminV.NavigationService.Navigate(new LootAdminV(this));
            }

        }


        #endregion


        #region LogiquePourCharAdmin

        internal void LoadCharAdminVM(CharactersAdminV charactersAdminV)
        {
            this.charAdminV = charactersAdminV;
            InitCharUC();
            InitCharLUC();
            InitCharActions();
        }


        private void InitCharUC()
        {
            currentChar = new Character();
            this.charAdminV.UCChar.Character = currentChar;
        }

        private void InitCharLUC()
        {
            this.charAdminV.LUCChar.LoadItems(currentParty.Personnages);
            //this.charAdminV.LUCChar.LoadItems((await charManager.Get()).ToList());
        }

        private void InitCharActions()
        {
            this.charAdminV.btnNouveau.Click += BtnNouveau_Click;
            this.charAdminV.btnMettreAjour.Click += BtnMettreAjour_Click;
            this.charAdminV.btnSupprimer.Click += BtnSupprimer_Click;
            this.charAdminV.UCChar.btnLoot.Click += BtnLoot_Click;

            this.charAdminV.LUCChar.ItemsList.SelectionChanged += ItemsList_SelectionChanged1;
        }

        private void ItemsList_SelectionChanged1(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            currentChar = (e.AddedItems[0] as Character);
            this.charAdminV.UCChar.Character = currentChar;
        }

        private async void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (this.charAdminV.UCChar.Character.Id != 0)
            {
                if (true)
                {
                    this.partyAdminV.LUCParty.Obs.Remove(partyAdminV.UCParty.Party);
                    await charManager.Delete(charAdminV.UCChar.Character);
                    currentParty = new Party();
                    this.partyAdminV.UCParty.Party = currentParty;
                }
            }
            else
            {
                MessageBox.Show("Vous devez selectionner un object a supprimer", "Delete Char", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private async void BtnMettreAjour_Click(object sender, RoutedEventArgs e)
        {
            if (this.charAdminV.UCChar.Character.Id != 0)
            {
                await charManager.Update(this.charAdminV.UCChar.Character);
            }
            else
            {
                await charManager.Insert(this.charAdminV.UCChar.Character);
                this.charAdminV.UCChar.Character = currentChar;
            }
        }

        private void BtnNouveau_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            InitCharUC();
        }

        private void BtnLoot_Click(object sender, RoutedEventArgs e)
        {
            if (currentChar.Id == 0)
            {
                if (MessageBox.Show("Vous devez sauvegarde le personnage " + this.charAdminV.UCChar.Character.Name + " avant de pouvoir acceder au sac, Souhaitez vous le faire ? ", "Save Personnage", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    BtnMettreAjour_Click(sender, e);
                    this.charAdminV.NavigationService.Navigate(new LootAdminV(this));
                }
            }
            else
            {
                this.charAdminV.NavigationService.Navigate(new LootAdminV(this));
            }
            
        }

        #endregion


        #region LogiquePourPartyAdminLoot

        internal void LoadLootAdminVM(LootAdminV lootAdminV)
        {
            this.lootAdminV = lootAdminV;
            InitUCLoot();
            InitLUCLLoot();
            InitActionsLoot();
        }

        private void InitUCLoot()
        {
            if (charAdminV != null)
            {
                currentChar = this.charAdminV.UCChar.Character;
            }
            currentParty = this.partyAdminV.UCParty.Party;
            currentLoot = new Loot();
            this.lootAdminV.UCLoot.Loot = currentLoot;
        }

        private async void InitLUCLLoot()
        {
            if (charAdminV != null)
            {
                charManager.GetLoot(currentChar);
                this.lootAdminV.LUCLoot.LoadItems((currentChar.Equipement).ToList());
            }
            else
            {
                partyManager.GetLoot(currentParty);
                this.lootAdminV.LUCLoot.LoadItems((currentParty.Bag).ToList());
            }

            this.lootAdminV.LUCItems.LoadItems((await itemsManager.Get()).ToList());
        }

        private void InitActionsLoot()
        {
            this.lootAdminV.LUCLoot.ItemsList.SelectionChanged += ItemsListLoot_SelectionChanged;
            this.lootAdminV.LUCItems.ItemsList.SelectionChanged += ItemsList_SelectionItemsChanged;

            this.lootAdminV.btnNouveau.Click += BtnNouveauLoot_Click;
            this.lootAdminV.btnMettreAjour.Click += BtnMettreAjourLoot_Click;
            this.lootAdminV.btnSupprimer.Click += BtnSupprimerLoot_Click;
        }

        private void ItemsList_SelectionItemsChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                currentItem = (e.AddedItems[0] as Items);
                currentLoot.ItemsId = currentItem.Id;
            }
        }

        private async void BtnMettreAjourLoot_Click(object sender, RoutedEventArgs e)
        {
            if (this.lootAdminV.UCLoot.Loot.Id != 0)
            {
                currentLoot = this.lootAdminV.UCLoot.Loot;
                await lootManager.Update(currentLoot);

                //await partyManager.Update(this.partyAdminV.UCParty.Party);
                this.lootAdminV.NavigationService.GoBack();
            }
            else
            {
                if (charAdminV == null)
                {
                    currentParty.Bag.Add(this.lootAdminV.UCLoot.Loot);
                    await partyManager.Update(currentParty);
                    this.lootAdminV.NavigationService.GoBack();
                }
                else
                {
                    currentChar.Equipement.Add(this.lootAdminV.UCLoot.Loot);
                    await charManager.Update(currentChar);
                    this.lootAdminV.NavigationService.GoBack();
                }
            }
        }

        private async void BtnSupprimerLoot_Click(object sender, RoutedEventArgs e)
        {
            if (this.lootAdminV.UCLoot.Loot.Id != 0)
            {
                if (MessageBox.Show("Voulez vous vraiement supprimer l'item " + this.lootAdminV.UCLoot.Loot.Id + " ?", "Supprimer Item", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {

                    this.lootAdminV.LUCLoot.Obs.Remove(lootAdminV.UCLoot.Loot);

                    if (charAdminV != null)
                    {
                        currentChar.Equipement.Remove(currentLoot);
                    }
                    else
                    {
                        currentParty.Bag.Remove(currentLoot);
                    }

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

        private void ItemsListLoot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                currentLoot = (e.AddedItems[0] as Loot);
                this.lootAdminV.UCLoot.Loot = currentLoot;
            }
        }
        #endregion

    }


}
