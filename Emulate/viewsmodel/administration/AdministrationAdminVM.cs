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
using System.Windows.Controls;

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
        }

        #region MethodeActionAdmin

        private void BtnPartie_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            InvokePage(new PartyAdminV());

            //this.administrationViews.NavigationService.Navigate(new PartyAdminV(this));
        }

        private void BtnItems_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            InvokePage(new ItemsAdminV());
        }

        private void BtnPlayer_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            InvokePage(new CharactersAdminV());
        }

        private void BtnDonjon_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            InvokePage(new DonjonAdminV());
        }
        
        private void BtnBoss_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            InvokePage(new BossAdminV());
        }

        private void BtnLoot_Click(object sender, RoutedEventArgs e)
        {
            InvokePage(new LootAdminV());
        }

        private void InvokePage(Page page)
        {
            NavigationWindow window = new NavigationWindow();
            window.Content = page;
            window.Show();
        }







        #endregion

    }
}

