using Emulate.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulate.database.entitieslinks
{
    public class MySQLItemsManager : MySQLManager<Items>
    {
        public void GetBoss(Items item)
        {
            bool isDetached = this.Entry(item).State == EntityState.Detached;
            if (isDetached)
                this.DbSetT.Attach(item);
            this.Entry(item).Reference(x => x.Boss).Load();
        }
    }
}
