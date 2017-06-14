using Emulate.entities.bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulate.entities
{
    public class Loot : BaseDBEntity
    {
        //[Key, ForeignKey("Party")]
        private Party party;

        //[Key, ForeignKey("Character")]
        private Character character;

        //[Key, ForeignKey("Items")]
        //private Items items;
        private Int32 itemsId;

        public Loot()
        {
        }



        public Party Party
        {
            get { return party; }
            set
            {
                party = value;
                OnPropertyChanged("Party");
            }
        }


        public Character Character
        {
            get { return character; }
            set
            {
                character = value;
                OnPropertyChanged("Character");
            }
        }

        public Int32 ItemsId
        {
            get { return itemsId;}
            set { itemsId = value;
                OnPropertyChanged("ItemsId");
            }
        }

        //public Items Items
        //{
        //    get { return items; }
        //    set
        //    {
        //        items = value;
        //        OnPropertyChanged("Items");
        //    }
        //}


    }
}
