using Emulate.entities.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulate.entities
{
    public class Classe : BaseDBEntity
    {
        private string nomClasse;

        public string NomClasse
        {
            get
            {
                return nomClasse;
            }

            set
            {
                nomClasse = value;
            }
        }
    }
}
