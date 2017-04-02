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
        string Nom;
        string Classe;
        int ilvl;
    }
}
