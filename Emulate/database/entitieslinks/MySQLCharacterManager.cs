using Emulate.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulate.database.entitieslinks
{
    public class MySQLCharacterManager : MySQLManager<Character>
    {
        public void GetLoot(Character character)
        {
            bool isDetached = this.Entry(character).State == EntityState.Detached;
            if (isDetached)
                this.DbSetT.Attach(character);
            this.Entry(character).Collection(x => x.Equipement).Load();
        }

    }
}
