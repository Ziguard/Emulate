using Emulate.entities.bases;
using Emulate.entities.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulate.entities
{
    public class Character : BaseDBEntity
    {
        private String name;
        private Int32 ilvl;
        private Classes classes;
        private Party party;
        private List<Loot> equipement;


        public Character()
        {
            this.equipement = new List<Loot>();
        }

        public string Name
        {
            get { return name; }
            set {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public Int32 Ilvl
        {
            get { return ilvl; }
            set
            {
                ilvl = value;
                OnPropertyChanged("Ilvl");
            }
        }

        public Classes Classes
        {
            get { return classes; }

            set {
                classes = value;
                OnPropertyChanged("Classes");
            }
        }

        public Party Party
        {
            get { return party; }
            set {
                party = value;
                OnPropertyChanged("Party");   
            }
        }

        public List<Loot> Equipement
        {
            get { return equipement; }
            set
            {
                equipement = value;
                OnPropertyChanged("Equipement");
            }
        }
    }
}
