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
        private DateTime lastConnect;
        private Int32 donjonLancerId;
        private List<Loot> bag;
        private List<Character> Characters;
        
        

        public Party()
        {
            this.Characters = new List<Character>();
            this.bag = new List<Loot>();
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

        public DateTime LastConnect
        {
            get { return this.lastConnect; }
            set
            {
                this.lastConnect = value;
                OnPropertyChanged("LastConnect");
            }
        }

        public List<Loot>Bag
        {
            get { return bag ;}
            set { bag = value;
                OnPropertyChanged("Bag");
            }
        }

        public List<Character> Personnages
        {
            get
            {
                return this.Characters;
            }
            set
            {
                this.Characters = value;
                OnPropertyChanged("Personnages");
            }
        }

        public Int32 DonjonLancerId
        {
            get
            {
                return donjonLancerId;
            }
            set
            {
                donjonLancerId = value;
                OnPropertyChanged("DonjonLancerId");
            }
        }



    }
}
