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

namespace Emulate.viewsmodel.administration
{
    public class AdministrationAdminVM
    {
        #region DefinitionViews
        private AdministrationViews administrationViews;
        private PartyAdminV partyAdminV;


        #endregion

        #region DefinitionEntities

        private Party currentParty;
        private Personnage currentPersonnage;
        private Donjon currentDonjon;
        private Items currentItem;

        #endregion

        #region DefinitionManager

        private MySQLPartyManager partyManager = new MySQLPartyManager();
        private MySQLDonjonManager donjonManager = new MySQLDonjonManager();
        private MySQLManager<Personnage> personnageManager = new MySQLManager<Personnage>();

        #endregion



        public AdministrationAdminVM(AdministrationViews administrationViews)
        {
            this.administrationViews = administrationViews;
            //InitUC();
            //InitLUC();
            InitActions();
        }

        private void InitActions()
        {
            this.administrationViews.btnPartie.Click += BtnPartie_Click;
            this.administrationViews.btnPlayer.Click += BtnPlayer_Click;

            this.administrationViews.btnDonjon.Click += BtnDonjon_Click;
            this.administrationViews.btnBoss.Click += BtnBoss_Click;
            this.administrationViews.btnItems.Click += BtnItems_Click;
        }


        #region MethodeActionAdmin

        private void BtnPartie_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.administrationViews.NavigationService.Navigate(new PartyAdminV(this));
        }

        private void BtnItems_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //NavigationWindow window = new NavigationWindow();
            //window.Content = new ItemsAdmin();
            //window.Show();
        }

        private void BtnPlayer_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            //NavigationWindow window = new NavigationWindow();
            //window.Content = new PersonnageAdmin();
            //window.Show();
        }

        private void BtnDonjon_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //NavigationWindow window = new NavigationWindow();
            //window.Content = new DonjonAdmin();
            //window.Show();
        }
        
        private void BtnBoss_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //NavigationWindow window = new NavigationWindow();
            //window.Content = new BossAdmin();
            //window.Show();
        } 
        #endregion


        #region LogiquePourAdminParty
        internal void LoadPartyAdminVM(PartyAdminV partyAdminV)
        {
            this.partyAdminV = partyAdminV;
            InitLUCParty();
            InitUCParty();
            InitPartyACtions();

        }

        private void InitUCParty()
        {
            currentParty = new Party();
            this.partyAdminV.UCParty.Party = currentParty;
        }

        private void InitPartyACtions()
        {
            this.partyAdminV.btnNew.Click += BtnNew_Click;
            this.partyAdminV.btnUpdate.Click += BtnUpdate_Click;
            this.partyAdminV.btnDelete.Click += BtnDelete_Click;
            this.partyAdminV.LUCParty.ItemsList.SelectionChanged += ItemsList_SelectionChanged;
        }

        private void ItemsList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Party item = (e.AddedItems[0] as Party);
            currentParty = item;
        }

        private void BtnUpdate_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDelete_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.partyAdminV.currentParty.Id != 0)
            {
                if (System.Windows.Forms.MessageBox.Show("Do you want to delete " + this.zooAdmin.ucZoo.Zoo.Name + " Zoo?", "Delete Zoo",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                 == DialogResult.Yes)
                {
                    this.zooAdmin.UCZooList.Obs.Remove(zooAdmin.ucZoo.Zoo);
                    await zooManager.Delete(zooAdmin.ucZoo.Zoo);
                    currentZoo = new Zoo();
                    this.zooAdmin.ucZoo.Zoo = currentZoo;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("You must select an object to delete it... ", "Delete Zoo",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void BtnNew_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void InitLUCParty()
        {
            this.partyAdminV.LUCParty.LoadItems((await partyManager.Get()).ToList());
        }
        #endregion
    }
}
