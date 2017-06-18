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
        private Character currentPersonnage;
        private Donjon currentDonjon;
        private Boss currentBoss;
        private Loot itemAddChar;

        private Random randomBoss = new Random();
        private Random random = new Random();


        #endregion

        #region DefinitionManager

        private MySQLPartyManager partyManager = new MySQLPartyManager();
        private MySQLDonjonManager donjonManager = new MySQLDonjonManager();
        private MySQLBossManager bossManager = new MySQLBossManager();
        private MySQLItemsManager itemsManager = new MySQLItemsManager();
        private MySQLManager<Character> personnageManager = new MySQLManager<Character>();
        private MySQLManager<Loot> lootManager = new MySQLManager<Loot>();

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
            currentPersonnage = new Character();
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
            partyManager.GetLoot(currentParty);

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
            this.playViews.UCListLootSac.ItemsList.SelectionChanged += ItemsListLoot_SelectionChanged;
            this.playViews.UCPersonnage.btnAnneau.Click += BtnAnneau_Click;
            this.playViews.UCPersonnage.btnCou.Click += BtnCou_Click;
            this.playViews.UCPersonnage.btnDos.Click += BtnDos_Click;

            this.playViews.btnDonjon.Click += BtnDonjon_Click;
        }

        private void ItemsListLoot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                itemAddChar = (e.AddedItems[0] as Loot);
            }
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

        private async void BtnDos_Click(object sender, RoutedEventArgs e)
        {
            Emplacement emplacement = Emplacement.DOS;
            await EquiperDesequiper(emplacement);
        }



        private async void BtnCou_Click(object sender, RoutedEventArgs e)
        {
            Emplacement emplacement = Emplacement.CASQUE;
            await EquiperDesequiper(emplacement);
        }

        private async void BtnAnneau_Click(object sender, RoutedEventArgs e)
        {
            Emplacement emplacement = Emplacement.ANNEAU;
            await EquiperDesequiper(emplacement);
        }

        private void ItemsListPersonnage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                currentPersonnage = (e.AddedItems[0] as Character);
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
            this.playViews.UCListLootSac.LoadItems(currentParty.Bag.ToList());
            this.playViews.UCListDonjon.LoadItems((await donjonManager.Get()).ToList());
        }


        private async Task EquiperDesequiper(Emplacement emplacement)
        {
            if (currentPersonnage != null)
            {
                Loot itemAddBag = new Loot();

                foreach (Loot equiper in currentPersonnage.Equipement)
                {
                    Items itemEquiper = await itemsManager.Get(equiper.ItemsId);

                    if (itemEquiper.Emplacement == emplacement)
                    {
                        itemAddBag = equiper;
                    }

                    currentParty.Bag.Remove(itemAddChar);
                    currentPersonnage.Equipement.Add(itemAddChar);

                    currentParty.Bag.Add(itemAddBag);
                    currentPersonnage.Equipement.Remove(itemAddBag);

                    Int32 ilvlEquipement = 0;

                    foreach (Loot loot in currentPersonnage.Equipement)
                    {
                        Items item = await itemsManager.Get(loot.ItemsId);
                        ilvlEquipement = item.Ilvl + ilvlEquipement;
                    }
                    currentPersonnage.Ilvl = ilvlEquipement / currentPersonnage.Equipement.Count();

                }
                await partyManager.Update(currentParty);
            }
            else
            {
                MessageBox.Show("veuillez selectionner un personnage... ", "Pas de personnage selectionner", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            
        }

        #endregion


        #region LogiquePourDonjonStart

        internal void LoadDonjonStartPage(DonjonStartViews donjonStartViews)
        {
            this.donjonStratViews = donjonStartViews;
            donjonManager.GetBoss(currentDonjon);
            InitDonjonStartLUC();
            InitDonjonStartActions();

        }
        private void InitDonjonStartLUC()
        {
            this.donjonStratViews.UCListBoss.LoadItems(currentDonjon.ListeBoss);
        }


        private void InitDonjonStartActions()
        {
            this.donjonStratViews.UCListBoss.ItemsList.SelectionChanged += ItemsListBoss_SelectionChanged;
            this.donjonStratViews.btnLancerQuete.Click += BtnLancerQuete_Click;
            this.donjonStratViews.btnCancel.Click += BtnCancel_Click;
        }

        private void ItemsListBoss_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentBoss = (e.AddedItems[0] as Boss);
            bossManager.GetItems(currentBoss);
            this.donjonStratViews.UCListLoot.LoadItems(currentBoss.ListLoot);
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.donjonStratViews.NavigationService.GoBack();
        }

        /// <summary>
        /// Permet de lancer un donjon et d'effectuer l'attribution des loot au sac du groupe si le donjon est terminé.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnLancerQuete_Click(object sender, RoutedEventArgs e)
        {
            //Test si le donjon lancer est terminer ou pas
            if (currentParty.LastConnect < DateTime.Now)
            {
                //Test si la partie contient bien un donjon lancer ou pas 
                if (currentParty.DonjonLancerId != 0)
                {
                    //Si un donjon a été lancer récupère le donjon en question en base de donnée par rapports a l'id sauvegarder sur la partie.
                    Donjon endDonjon = await donjonManager.Get(currentParty.DonjonLancerId);

                    Int32 minValueRand = getIlvlParty();

                    Random win = new Random();

                    //Effectue un rand par rapprot a la diffuculté du donjon.
                    if (endDonjon.IlvlLuck < win.Next(minValueRand, 200))
                    {
                        //Pour chaque boss de la liste du donjon effectue un rand sur la plage de loot et ajoute le loot en question a la liste d'item de la partie ( sac ) 
                        foreach (Boss bossTuer in endDonjon.ListeBoss)
                        {
                            bossManager.GetItems(bossTuer);
                            Items itemLoot = bossTuer.ListLoot[randomBoss.Next(1, bossTuer.ListLoot.Count())-1];
                            Loot nouveauLoot = new Loot();
                            nouveauLoot.ItemsId = itemLoot.Id;
                            currentParty.Bag.Add(nouveauLoot);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Pas de chance Les Boss du donjon vous on reboot...!!! Retentez votre chance.  Le niveau de votre groupe actuel est de " + minValueRand + " et celui du donjon consieller est", "Epique Fail", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    }
                    //Lance le nouveau donjon selectionner
                    await affectationDonjon();
                }

                else
                {
                    await affectationDonjon();
                }
            }
            else
            {
                MessageBox.Show("Un donjon est déjà en cours veuillez patienter", "Donjon en cours", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        }

        private Int32 getIlvlParty()
        {
            Int32 ilvlGroupe = 0;
            Int32 ilvlPersonnage = 0;

            foreach (Character personnage in currentParty.Personnages)
            {
                ilvlPersonnage = ilvlPersonnage + personnage.Ilvl;
            }
            ilvlGroupe = ilvlPersonnage / currentParty.Personnages.Count();
            return ilvlGroupe;
        }

        /// <summary>
        /// Defini la date de fin du donjon et le sauvegarde sur la partie actuel.
        /// </summary>
        /// <returns></returns>
        private async Task affectationDonjon()
        {
            DateTime endTimeDonjon = DateTime.Now + currentDonjon.Temps;
            currentParty.DonjonLancerId = currentDonjon.Id;
            currentParty.LastConnect = endTimeDonjon;
            await partyManager.Update(currentParty);
        }

        #endregion

    }
}
