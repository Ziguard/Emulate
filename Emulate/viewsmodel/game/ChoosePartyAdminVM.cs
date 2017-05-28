using Emulate.database;
using Emulate.entities;
using Emulate.views.administration;
using Emulate.views.game;
using Emulate.views.usercontrols.usercontrols;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using Emulate.database.entitieslinks;
using Emulate.entities.enums;

namespace Emulate.viewsmodel
{
    public class ChoosePartyAdminVM
    {
        #region DefinitionViews

        private ChoosePartyViews chooseAdmin;
        private CreatePartyViews createPartyAdmin;
        private CreateCharViews createCharViews;
        private PlayViews playViews;
        private DonjonStartViews donjonStratViews;
        private DateTime lancementDonjon;


        #endregion

        #region DefinitionEntities

        private Party currentParty;
        private Personnage currentPersonnage;
        private Donjon currentDonjon;
        private List<Personnage> currentGroupe;

        #endregion

        #region DefinitionManager

        private MySQLPartyManager partyManager = new MySQLPartyManager();
        private MySQLDonjonManager donjonManager = new MySQLDonjonManager();
        private MySQLManager<Personnage> personnageManager = new MySQLManager<Personnage>(); 

        #endregion
        
        /// <summary>
        /// Lancement de la vue Choix Partie
        /// </summary>
        /// <param name="chooseAdmin"></param>
        public ChoosePartyAdminVM(ChoosePartyViews chooseAdmin)
        {
            this.chooseAdmin = chooseAdmin;
            InitUC();
            InitLUC();
            InitActions();
        }

        private async void InitLUC()
        {
            this.chooseAdmin.UCListParty.LoadItems((await partyManager.Get()).ToList());
        }

        private void InitUC()
        {
            currentParty = new Party();
            this.chooseAdmin.UCParty.Party = currentParty;
        }
        
        /// <summary>
        /// Recupération des évenement
        /// </summary>
        private void InitActions()
        {
            this.chooseAdmin.UCListParty.ItemsList.SelectionChanged += ItemsList_SelectionChanged;
            this.chooseAdmin.UCParty.btnStart.Click += BtnStart_Click;
            this.chooseAdmin.UCParty.btnNew.Click += BtnNew_Click;
        }

        private void ItemsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Party item = (e.AddedItems[0] as Party);
            currentParty = item;
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            partyManager.GetGroupe(currentParty);

            if (currentParty.Personnages.Count < 5)
            {
                //Affichage Fenetre Creation Personnage
                this.chooseAdmin.NavigationService.Navigate(new CreateCharViews(this));
            }
            else
            {
                //Affichage Fenetre de jeux
                this.chooseAdmin.NavigationService.Navigate(new PlayViews(this));
            }
        }

        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
            this.chooseAdmin.NavigationService.Navigate(new CreatePartyViews(this));
        }


        #region LogiquePourCreateParty

        internal void LoadCreatePartyPage(CreatePartyViews createPartyAdmin)
        {
            this.createPartyAdmin = createPartyAdmin;
            InitCreatePartyActions();
        }

        private void InitCreatePartyActions()
        {
            this.createPartyAdmin.btnValidate.Click += BtnCreateParty_Click;
        }

        private async void BtnCreateParty_Click(object sender, RoutedEventArgs e)
        {
            currentParty.Name = this.createPartyAdmin.txtBPartyName.Text;
            await partyManager.Insert(currentParty);

            //Task<Party> tParty = partyManager.Insert(currentParty);
            //currentParty = (Party)tParty.Result;


            this.chooseAdmin.UCListParty.AddItem(currentParty);
            this.createPartyAdmin.NavigationService.Navigate(new CreateCharViews(this));
            //Task<Party> tParty = partyManager.Insert(currentParty);

        }
        #endregion


        #region LogiquePourCreePersonnage
        internal void LoadCreateCharPage(CreateCharViews createCharViews)
        {
            currentPersonnage = new Personnage();
            this.createCharViews = createCharViews;
            InitCreatePersonnageActions();
        }
        
        private void InitCreatePersonnageActions()
        {
            this.createCharViews.UCPersonnage.btnCreate.Click += BtnCreatePersonnage_Click;
        }

        private async void BtnCreatePersonnage_Click(object sender, RoutedEventArgs e)
        {
            currentPersonnage.Name = this.createCharViews.UCPersonnage.tbtNameClasse.Text;
            currentPersonnage.Classes = (Classes)Enum.ToObject(typeof(Classes), this.createCharViews.UCPersonnage.cmbClasse.SelectedValue);
            currentPersonnage.Ilvl = 0;
            currentParty.Personnages.Add(currentPersonnage);
            await partyManager.Update(currentParty);

            if (currentParty.Personnages.Count == 5)
            {
                this.createCharViews.NavigationService.Navigate(new PlayViews(this));
            }
            else
            {
                this.createCharViews.NavigationService.Navigate(new CreateCharViews(this));
                //this.createCharViews.NavigationService.GoBack();
            }
        }
        #endregion


        #region LogiquePourPlayViews
        internal void LoadPlayViews(PlayViews playViews)
        {
            this.playViews = playViews;
            InitLUCPersonnage();
            InitUCPersonnage();
            InitPlayViewsActions();
        }

        private void InitUCPersonnage()
        {
            this.playViews.UCPersonnage.Personnage = currentPersonnage;
            this.chooseAdmin.UCParty.Party = currentParty;
        }

        private void InitPlayViewsActions()
        {
            this.playViews.UCListPersonnage.ItemsList.SelectionChanged += ItemsListPersonnage_SelectionChanged;
            this.playViews.UCListDonjon.ItemsList.SelectionChanged += ItemsListDonjon_SelectionChanged;
            this.playViews.UCPersonnage.btnAnneau.Click += BtnAnneau_Click;
            this.playViews.UCPersonnage.btnCou.Click += BtnCou_Click;
            this.playViews.UCPersonnage.btnDos.Click += BtnDos_Click;

            this.playViews.btnDonjon.Click += BtnDonjon_Click;
        }

        private void ItemsListDonjon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                currentDonjon = (e.AddedItems[0] as Donjon);
            }
        }

        private void BtnDonjon_Click(object sender, RoutedEventArgs e)
        {
            if (currentDonjon != null)
            {
                this.playViews.NavigationService.Navigate(new DonjonStartViews(this));
            }
            else
            {
                MessageBox.Show("You must select a donjon to go to this page... ", "No donjon selected", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        }

        private void BtnDos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCou_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAnneau_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ItemsListPersonnage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                currentPersonnage = (e.AddedItems[0] as Personnage);
                this.playViews.UCPersonnage.Personnage = currentPersonnage;
                //this.playViews.UCPersonnage..Content = currentPersonnage.Nom;
                
                //zooManager.GetAddress(currentZoo);
                //zooManager.GetEmployees(currentZoo);
                //zooManager.GetStructures(currentZoo);
            }
        }

        /// <summary>
        /// Initalise les UserControlList Donjon et Personnage
        /// </summary>
        private async void InitLUCPersonnage()
        {
            this.playViews.UCListPersonnage.LoadItems(currentParty.Personnages);
            
            //Recuperation de la liste des item de la base de donnes via le manager
            //this.playViews.UCListPersonnage.LoadItems((await personnageManager.Get()).ToList());
            this.playViews.UCListDonjon.LoadItems((await donjonManager.Get()).ToList());
        }

        #endregion


        #region LogiquePourDonjonStrat

        internal void LoadDonjonStartPage(DonjonStartViews donjonStartViews)
        {
            this.donjonStratViews = donjonStartViews;
            donjonManager.GetBoss(currentDonjon);
            InitDonjonStartLUC();
            InitDonjonStartActions();

        }

        private void InitDonjonStartActions()
        {
            this.donjonStratViews.btnLancerQuete.Click += BtnLancerQuete_Click;
            this.donjonStratViews.btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.donjonStratViews.NavigationService.GoBack();
        }

        private async void BtnLancerQuete_Click(object sender, RoutedEventArgs e)
        {

            //Todo si le precedent donjon est terminer lancer la fenetre de rand sur le booss
            //foreach (Boss boos in currentDonjon.ListeBoss)
            //{
            //    //Lancer la Fenetre de rand.

            //}
            DateTime test = new DateTime();
            lancementDonjon = DateTime.Now;
            test = currentParty.LastConnect + currentDonjon.Temps;

            if (test > lancementDonjon  )
            {
                //retour a la playviews
                this.donjonStratViews.NavigationService.GoBack();
                MessageBox.Show("Un donjon est déjà en courts veuillez patienter", "Donjon in Progress", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                currentParty.LastConnect = lancementDonjon;
                await partyManager.Update(currentParty);

            }
            
        }

        private void InitDonjonStartLUC()
        {
            this.donjonStratViews.UCListBoss.LoadItems(currentDonjon.ListeBoss);
        }
        #endregion

    }
}
