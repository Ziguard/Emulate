using Emulate.views.administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulate.viewsmodel
{
    public class ClasseAdminVM
    {
        private ClassesAdmin classesAdmin;

        private PartyAdmin partyAdmin;
        private MySQLManager<Party> partyManager = new MySQLManager<Party>();
        private Application application;

        public  (PartyAdmin partyAdmin)
        {
            this.partyAdmin = partyAdmin;
            InitUC();
            InitLUC();
            InitActions();
        }
}
