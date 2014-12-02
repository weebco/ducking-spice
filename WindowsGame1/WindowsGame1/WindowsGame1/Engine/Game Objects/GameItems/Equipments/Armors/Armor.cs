using System;

namespace WindowsGame1.Engine.GameItems.Equipments.Armors
    {
    public  class Armor : Equipment
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
        public ArmorTypes armorType { get; set; }
        public int armorValue { get; set; }

        public Armor(String name, ArmorSlot armorSlot, ArmorTypes armorType, int armorValue, Boolean isLootable, int durability) : base(name, isLootable, durability)
        {
            this.armorSlot = armorSlot;
            this.armorType = armorType;
            this.armorValue = armorValue;
        }

        }
    }
