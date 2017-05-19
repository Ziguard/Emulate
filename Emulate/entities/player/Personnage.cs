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
        private string nom;
        private string classe;
        private int ilvl;

        public int Ilvl
        {
            get { return ilvl; }
            set { ilvl = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Classe
        {
            get { return classe; }

            set { classe = value; }
        }
    }
}
