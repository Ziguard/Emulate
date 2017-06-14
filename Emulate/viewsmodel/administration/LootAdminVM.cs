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
    public class LootAdminVM
    {
        private LootAdminV lootAdminV;

        private Loot currentLoot;
        private Items currentItems;
        private Party currentParty;
        private Character currentCharacter;

        private MySQLManager<Loot> lootManager = new MySQLManager<Loot>();
        private MySQLManager<Items> itemsManager = new MySQLManager<Items>();
        private MySQLManager<Party> partyManager = new MySQLManager<Party>();
        private MySQLManager<Character> characterManager = new MySQLManager<Character>();


        public LootAdminVM(LootAdminV lootAdminViews)
        {
            this.lootAdminV = lootAdminViews;
            InitUCLoot();
            InitLUCLoot();
            InitActionsLoot();
        }

        private void InitUCLoot()
        {
            currentLoot = new Loot();
            this.lootAdminV.UCLoot.Loot = currentLoot;
        }

        private async void InitLUCLoot()
        {
            this.lootAdminV.LUCLoot.LoadItems((await lootManager.Get()).ToList());
            this.lootAdminV.LUCItems.LoadItems((await itemsManager.Get()).ToList());
        }

        private void InitActionsLoot()
        {
            this.lootAdminV.LUCLoot.ItemsList.SelectionChanged += ItemsList_SelectionPartyChanged;
            this.lootAdminV.LUCItems.ItemsList.SelectionChanged += ItemsList_SelectionItemsChanged;

            this.lootAdminV.btnNouveau.Click += BtnNouveau_Click;
            this.lootAdminV.btnMettreAjour.Click += BtnMettreAjour_Click;
            this.lootAdminV.btnSupprimer.Click += BtnSupprimer_Click;
        }

        private void ItemsList_SelectionPartyChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                currentLoot = (e.AddedItems[0] as Loot);
                this.lootAdminV.UCLoot.Loot = currentLoot;
            }
        }

        private void ItemsList_SelectionItemsChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count >0)
            {
                currentItems = (e.AddedItems[0] as Items);
                this.lootAdminV.UCLoot.Loot.ItemsId = currentItems.Id;
            }
        }

        private void BtnNouveau_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            InitUCLoot();
        }


        private async void BtnSupprimer_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.lootAdminV.UCLoot.Loot.Id != 0)
            {
                if (MessageBox.Show("Voulez vous vraiement supprimer l'item " + this.lootAdminV.UCLoot.Loot.Id + " ?", "Supprimer Item", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    this.lootAdminV.LUCLoot.Obs.Remove(lootAdminV.UCLoot.Loot);
                    await lootManager.Delete(lootAdminV.UCLoot.Loot);
                    currentLoot = new Loot();
                    this.lootAdminV.UCLoot.Loot = currentLoot;
                }
            }
            else
            {
                MessageBox.Show("Vous devez selectionner un object a supprimer", "Supprimer Loot", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private async void BtnMettreAjour_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.lootAdminV.UCLoot.Loot.Id != 0)
            {
                currentLoot = this.lootAdminV.UCLoot.Loot;
                await lootManager.Update(currentLoot);
            }
            else
            {
                //Recupere la partie par rapport a l'id saisie
                currentParty = await partyManager.Get(Convert.ToInt32(this.lootAdminV.UCLoot.txtParty.Text));

                //affecter au loot la party retrouvé
                currentLoot.Party = currentParty;

                //test si l'id du personnage est renseigner ou pas
                if (this.lootAdminV.UCLoot.txtCharacter.Text != "")
                {
                    //recupere le personnage par rapport a l'id saisie
                    currentCharacter = await characterManager.Get(Convert.ToInt32(this.lootAdminV.UCLoot.txtCharacter.Text));
                    //affecte le personnage retrouvé
                    currentLoot.Character = currentCharacter;
                    //rajouter 
                    currentCharacter.Equipement.Add(currentLoot);
                }
                else
                {
                    currentParty.Bag.Add(currentLoot);
                }
                await lootManager.Insert(currentLoot);
                //TODO verifier si l'id de l'item est bien présent ... 
                this.lootAdminV.LUCLoot.Obs.Add(currentLoot);
                this.lootAdminV.UCLoot.Loot = currentLoot;
            }
        }

    }
}
