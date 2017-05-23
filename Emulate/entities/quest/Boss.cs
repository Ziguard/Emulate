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
        String nom;
        List<Items> listeLoot;

        public Boss()
        {

        }


        public String Nom
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

        public List<Items> ListeLoot
        {
            get
            {
                return listeLoot;
            }

            set
            {
                listeLoot = value;
                OnPropertyChanged("ListeLoot");
            }
        }
    }
}
