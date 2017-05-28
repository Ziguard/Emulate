using Emulate.entities.bases;
using Emulate.entities.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulate.entities
{
    public class Items : BaseDBEntity
    {
        private Int32 ilvl;
        private String name;
        private Emplacement emplacement;
        private Boss boss;
        private Party party;

        public Items()
        {

        }

        public int Ilvl
        {
            get
            {
                return ilvl;
            }

            set
            {
                ilvl = value;
                OnPropertyChanged("Ilvl");
            }
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

        public Emplacement Emplacement
        {
            get
            {
                return emplacement;
            }

            set
            {
                emplacement = value;
                OnPropertyChanged("Emplacement");
            }
        }

        public Boss Boss
        {
            get
            {
                return boss;
            }

            set
            {
                boss = value;
                OnPropertyChanged("Boss");
            }
        }

        public Party Party
        {
            get
            {
                return party;
            }

            set
            {
                party = value;
                OnPropertyChanged("Party");
            }
        }
    }
}