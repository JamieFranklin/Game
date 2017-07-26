using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum ItemType{
    AMOUR,
    WEAPON,
    CRAFT,
    MISC
}

namespace Game.Classes
{
    class Item
    {
        String ID;
        String displayName;
        ItemType type;

        public Item(String id, String name, ItemType itemType){
            ID = id;
            displayName = name;
            type = itemType;
        }

    }

    
}
