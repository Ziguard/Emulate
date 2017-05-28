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
    public class Personnage : BaseDBEntity
    {
        private String name;
        private Classes classes;
        private Int32 ilvl;
        private Party party;

        public Personnage()
        {

        }

        public int Ilvl
        {
            get { return ilvl; }
            set {
                ilvl = value;
                OnPropertyChanged("Ilvl");
            }
        }

        public string Name
        {
            get { return name; }
            set {
                name = value;
                OnPropertyChanged("Name");
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
    }
}
