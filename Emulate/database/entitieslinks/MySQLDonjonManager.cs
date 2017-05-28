using Emulate.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulate.database.entitieslinks
{
    public class MySQLDonjonManager : MySQLManager<Donjon>
    {
        public void GetBoss(Donjon donjon)
        {
            bool isDetached = this.Entry(donjon).State == EntityState.Detached;
            if (isDetached)
                this.DbSetT.Attach(donjon);
            this.Entry(donjon).Collection(x => x.ListeBoss).Load();
        }
    }
}
