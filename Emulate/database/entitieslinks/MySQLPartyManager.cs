using Emulate.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulate.database.entitieslinks
{
    public class MySQLPartyManager : MySQLManager<Party>
    {
        public void GetGroupe(Party party)
        {
            bool isDetached = this.Entry(party).State == EntityState.Detached;
            if (isDetached)
                this.DbSetT.Attach(party);
            this.Entry(party).Reference(x => x.Groupe).Load();
        }
    }
}

