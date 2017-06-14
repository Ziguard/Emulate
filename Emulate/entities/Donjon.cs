using Emulate.entities.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulate.entities
{
    public class Donjon : BaseDBEntity
    {
        String name;
        List<Boss> listeBoss;
        TimeSpan temps;
        Int32 ilvlLuck;


        public Donjon()
        {
            this.listeBoss = new List<Boss>();
        }

        public string Name
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

        public List<Boss> ListeBoss
        {
            get
            {
                return listeBoss;
            }

            set
            {
                listeBoss = value;
                OnPropertyChanged("ListeBoss");
            }
        }

        public TimeSpan Temps
        {
            get { return temps; }

            set { temps = value;
                OnPropertyChanged("Temps"); }
        }

        public int IlvlLuck
        {
            get
            {
                return ilvlLuck;
            }

            set
            {
                ilvlLuck = value;
                OnPropertyChanged("IlvlLuck");
            }
        }


    }
}
