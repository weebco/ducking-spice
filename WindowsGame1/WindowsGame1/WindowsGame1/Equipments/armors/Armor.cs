using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsGame1.Equipments.items;

namespace WindowsGame1.Equipments.armors
    {
    public  class Armor : Items
        {

        public enum ArmorTypes
        {
            CLOTH,
            LIGHT,
            HEAVY
        }

        public enum ArmorSlot
        {
            HEAD,
            CHEST,
            PANTS,
            SHOES
        }
        public ArmorSlot armorSlot { get; set; }
        public int armorValue { get; set; }



        }
    }
