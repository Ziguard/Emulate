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
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
