using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emulate.views.usercontrols.usercontrols;
using Emulate.entities;
using Emulate.views.game;
using Emulate.database;
using System.Windows;
using ClassLibrary2.Entities.Reflection;

namespace Emulate.viewsmodel
{
    class CreatePartyAdminVM
    {
        private Party currentParty;
        private CreatePartyViews createPartyAdmin;
        private MySQLManager<Party> partyManager = new MySQLManager<Party>();

        public CreatePartyAdminVM(CreatePartyViews createPartyAdmin)
        {
            this.createPartyAdmin = createPartyAdmin;

            InitUC();
        }

        private void InitUC()
        {
            throw new NotImplementedException();
        }
    }
}
