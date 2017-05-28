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
        private List<Personnage> personnages;
        private List<Items> bag;
        private DateTime lastConnect;

        public Party()
        {
            this.personnages = new List<Personnage>();
            this.bag = new List<Items>();
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

        public List<Personnage> Personnages
        {
            get
            {
                return this.personnages;
            }
            set
            {
                this.personnages = value;
                OnPropertyChanged("Personnages");
            }
        }

        public List<Items> Bag
        {
            get
            {
                return this.bag;
            }
            set
            {
                this.bag = value;
                OnPropertyChanged("Bag");
            }
        }

        public DateTime LastConnect
        {
            get { return this.lastConnect; }
            set {
                this.lastConnect = value;
                OnPropertyChanged("LastConnect"); }
        }
    }
}
