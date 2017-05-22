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

namespace Emulate.viewsmodel
{
    public class ChoosePartyAdminVM
    {
        private ChoosePartyViews chooseAdmin;
        private CreatePartyViews createPartyAdmin;
        private CreateCharViews createCharViews;

        private Party currentParty;
        private Personnage currentPersonnage;
        

        private MySQLManager<Party> partyManager = new MySQLManager<Party>();
        private MySQLManager<Personnage> personnageManager = new MySQLManager<Personnage>();

        public ChoosePartyAdminVM(ChoosePartyViews chooseAdmin)
        {
            this.chooseAdmin = chooseAdmin;
            InitUC();   
            InitLUC();
            InitActions();
        }
        
        private async void InitLUC()
        {
            //this.chooseAdmin.UCListParty.LoadItem((await partyManager.Get()).ToList());
        }


        /*Init UC*/
        private void InitUC()
        {
            currentParty = new Party();
            //currentZoo.Birth = DateTime.Now;
            this.chooseAdmin.UCParty.Party = currentParty;
        }
      
        private void InitActions()
        {
            //Affiche l'userControl de creationdePartie
            this.chooseAdmin.UCParty.btnNew.Click += BtnNew_Click;
            this.chooseAdmin.UCParty.btnStart.Click += BtnStart_Click;
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            currentParty = this.chooseAdmin.UCParty.Party;
            

            if (currentParty.Groupe == null)
            {
                this.chooseAdmin.NavigationService.Navigate(new CreateCharViews(this));
            }
            else
            {
                //await personnageManager.Get(currentPersonnage.Id);
                //TEST Si mission
                //Affichage de la mission en courts()
                //Ou Affichage de la fenetre de jeux comprenant la liste des personnage , la liste des donjon , le sac
            }



            //if (currentParty.Id != 0)
            //{
            //    try
            //    {
            //        await partyManager.Insert(currentParty);
            //    }
            //    catch (DbEntityValidationException dbe)
            //    {
            //        Console.WriteLine(dbe);
            //    }
            //}
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
            currentParty.Name = this.createPartyAdmin.txtBStreet.Text;
            await partyManager.Insert(currentParty);

            //Task<Party> tParty = partyManager.Insert(currentParty);
            this.createPartyAdmin.NavigationService.Navigate(new CreateCharViews(this));
        }
        #endregion


        #region LogiquePourCreePersonnage
        internal void LoadCreateCharPage(CreateCharViews createCharViews)
        {
            this.createCharViews = createCharViews;
            InitCreatePersonnageActions();
        }

        private void InitCreatePersonnageActions()
        {
            this.createCharViews.UCPersonnage.btnCreate.Click += BtnCreatePersonnage_Click;
        }

        private void BtnCreatePersonnage_Click(object sender, RoutedEventArgs e)
        {
            //TODO Erreur A Corriger
            currentPersonnage = this.createCharViews.UCPersonnage.Personnage;
            personnageManager.DbSetT.Attach(currentPersonnage);
        }
        #endregion
    }
}
