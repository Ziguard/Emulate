using Emulate.entities.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulate.entities
{
    public class Boss : BaseDBEntity
    {
        String name;
        List<Items> listLoot;
        TimeSpan tempsDonjon;

        public Boss()
        {
            this.listLoot = new List<Items>();
        }


        public String Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public List<Items> ListLoot
        {
            get
            {
                return listLoot;
            }

            set
            {
                listLoot = value;
                OnPropertyChanged("ListLoot");
            }
        }

        public TimeSpan TempsDonjon
        {
            get
            {
                return tempsDonjon;
            }

            set
            {
                tempsDonjon = value;
                OnPropertyChanged("TempsDonjon");
            }
        }
    }
}
