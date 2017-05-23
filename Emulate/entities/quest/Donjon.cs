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
        String nom;
        List<Boss> listeBoss;

        public Donjon()
        {

        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
                OnPropertyChanged("Nom");

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






    }
}
