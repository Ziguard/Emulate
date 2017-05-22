using Emulate.entities.bases;
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
        private String classe;
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

        public string Classe
        {
            get { return classe; }

            set {
                classe = value;
                OnPropertyChanged("Classes");
            }
        }
    }
}
