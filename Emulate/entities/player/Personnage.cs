using Emulate.entities.bases;
using Emulate.entities.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulate.entities


{
    public class Personnage : BaseDBEntity
    {
        private String nom;
        private Classes classes;
        private Int32 ilvl;

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

        public string Nom
        {
            get { return nom; }
            set {
                nom = value;
                OnPropertyChanged("Nom");
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
    }
}
