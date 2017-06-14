using Emulate.database;
using Emulate.database.entitieslinks;
using Emulate.entities;
using Emulate.views.administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using System.Windows;

namespace Emulate.viewsmodel.administration
{
    public class AdministrationAdminVM
    {
        private AdministrationViews administrationViews;

        public AdministrationAdminVM(AdministrationViews administrationViews)
        {
            this.administrationViews = administrationViews;
            InitActions();
        }

        private void InitActions()
        {
            this.administrationViews.btnPartie.Click += BtnPartie_Click;
            this.administrationViews.btnPlayer.Click += BtnPlayer_Click;

            this.administrationViews.btnLoot.Click += BtnLoot_Click;

            this.administrationViews.btnDonjon.Click += BtnDonjon_Click;
            this.administrationViews.btnBoss.Click += BtnBoss_Click;
            this.administrationViews.btnItems.Click += BtnItems_Click;

            //this.administrationViews.btnPrecedent.Click += BtnPrecedent_Click;
        }

        #region MethodeActionAdmin

        private void BtnPartie_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            window.Content = new PartyAdminV();
            window.Show();

            //this.administrationViews.NavigationService.Navigate(new PartyAdminV(this));
        }

        private void BtnItems_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            window.Content = new ItemsAdminV();
            window.Show();
        }

        private void BtnPlayer_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            NavigationWindow window = new NavigationWindow();
            window.Content = new CharactersAdminV();
            window.Show();
            
        }

        private void BtnDonjon_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            window.Content = new DonjonAdminV();
            window.Show();
        }
        
        private void BtnBoss_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            window.Content = new BossAdminV();
            window.Show();
        }

        private void BtnLoot_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            window.Content = new LootAdminV();
            window.Show();
        }




        #endregion

        #region LogiquePourAdminBoss

        //internal void LoadBossAdminVM(BossAdminV bossAdminV)
        //{
        //    this.bossAdminV = bossAdminV;

        //    InitLUCBoss();
        //    InitUCBoss();
        //    InitBossActions();
        //}

        //private void InitBossActions()
        //{
        //    this.bossAdminV.btnAjouter.Click += BtnBossNew_Click;
        //    this.bossAdminV.btnMettreAjour.Click += BtnBossMaj_Clik;
        //    this.bossAdminV.btnSupprimer.Click += BtnBossDel_Click;
        //    this.bossAdminV.LUCBoss.itemList.SelectionChanged += ItemList_SelectionChanged;
        //}

        //private void InitUCBoss()
        //{
        //    currentBoss = new Boss();
        //    this.bossAdminV.UCBoss.Boss = currentBoss;
        //}

        //private async void InitLUCBoss()
        //{
        //    this.bossAdminV.LUCBoss.LoadItems((await bossManager.Get()).ToList());
        //}

        //private void ItemList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        //{
        //    currentBoss = (e.AddedItems[0] as Boss);
        //    this.bossAdminV.UCBoss.Boss = currentBoss;
        //}


        //private void BtnBossNew_Click(object sender, RoutedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void BtnBossMaj_Clik(object sender, RoutedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void BtnBossDel_Click(object sender, RoutedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}




        //private PartyAdminV partyAdminV;
        //private ItemsAdminV itemsAdminV;
        //private BossAdminV bossAdminV;
        //private CharactersAdminV charAdminV;

        //private Party currentParty;
        //private Character currentPersonnage;
        //private Donjon currentDonjon;
        //private Boss currentBoss;
        //private Items currentItem;

        //private MySQLPartyManager partyManager = new MySQLPartyManager();
        //private MySQLDonjonManager donjonManager = new MySQLDonjonManager();
        //private MySQLBossManager bossManager = new MySQLBossManager();

        //private MySQLManager<Character> personnageManager = new MySQLManager<Character>();
        //private MySQLManager<Items> itemsManager = new MySQLManager<Items>();

        #endregion


    }
}

