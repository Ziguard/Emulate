using Emulate.database;
using Emulate.entities;
using Emulate.views.administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Emulate.viewsmodel
{
    public class PartyAdminVM
    {
        private PartyAdmin partyAdmin;
        private MySQLManager<Party> partyManager = new MySQLManager<Party>();
        private Application application;

        public PartyAdminVM(PartyAdmin partyAdmin)
        {
            this.partyAdmin = partyAdmin;
            InitUC();
            InitLUC();
            InitActions();

        }

        private void InitLUC()
        {
            throw new NotImplementedException();
        }

        private void InitUC()
        {
            throw new NotImplementedException();
        }

        private void InitActions()
        {
            this.partyAdmin.btnNew.Click += btNewParty_Clik;
            this.partyAdmin.btnValidate.Click += btnValidateParty_Click;
            this.partyAdmin.btnDelete.Click += btnDelParty_Click;
            //this.partyAdmin.
            //this.partyAdmin.UCJobList.ItemsList.SelectionChanged += ItemsList_SelectionChanged;
        }

        private void btnDelParty_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            //TODO Cree une nouvelle fenetre pour crée une partie
            //Gestion dans cette fenetre pour gere la creation de 
            //window.Content = 
        }

        private void btnValidateParty_Click(object sender, RoutedEventArgs e)
        {
            //await partyManager.
        }

        private void btNewParty_Clik(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
