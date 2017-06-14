using Emulate.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulate.database.entitieslinks
{
    public class MySQLBossManager : MySQLManager<Boss>
    {
        public void GetItems(Boss boss)
        {
            bool isDetached = this.Entry(boss).State == EntityState.Detached;
            if (isDetached)
                this.DbSetT.Attach(boss);
            this.Entry(boss).Collection(x => x.ListLoot).Load();
        }

        public void GetDonjon(Boss boss)
        {
            bool isDetached = this.Entry(boss).State == EntityState.Detached;
            if (isDetached)
                this.DbSetT.Attach(boss);
            this.Entry(boss).Reference(x => x.Donjon).Load();
        }
    }
}
