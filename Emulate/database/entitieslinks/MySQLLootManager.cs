using Emulate.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulate.database.entitieslinks
{
    public class MySQLLootManager : MySQLManager<Loot>
    {
        //public void GetItems(Loot loot)
        //{
        //    bool isDetached = this.Entry(loot).State == EntityState.Detached;
        //    if (isDetached)
        //        this.DbSetT.Attach(loot);
        //    this.Entry(loot).Reference(x => x.Items).Load();
        //}
    }
}
