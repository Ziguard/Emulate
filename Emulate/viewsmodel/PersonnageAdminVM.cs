using Emulate.views.administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emulate.entities;
using Emulate.views.game;

namespace Emulate.viewsmodel
{
    public class PersonnageAdminVM
    {
        //private Zoo currentZoo;
        //private ZooAdmin zooAdmin;
        //private Group currentGroup;
        private CreateCharViews personnageAdmin;

        public PersonnageAdminVM(CreateCharViews personnageAdmin)
        {
            this.personnageAdmin = personnageAdmin;

            InitUC();
            InitActions();
        }

        private void InitUC()
        {

        }

        private void InitActions()
        {

        }
    }
}
