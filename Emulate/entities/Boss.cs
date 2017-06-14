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
        Donjon donjon;
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

        public Donjon Donjon
        {
            get
            {
                return donjon;
            }

            set
            {
                donjon = value;
                OnPropertyChanged("Donjon");
            }
        }
    }
}
