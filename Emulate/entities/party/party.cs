using Emulate.entities.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulate.entities
{
    public class Party : BaseDBEntity
    {
        private String name;
        private List<Personnage> groupe;

        public Party()
        {

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

        public List<Personnage> Groupe
        {
            get
            {
                return this.groupe;
            }
            set
            {
                this.groupe= value;
                OnPropertyChanged("Groupe");
            }
        }
    }
}
