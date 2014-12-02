using System;

namespace WindowsGame1.Engine.GameItems.Equipments
{
    public class Equipment : Items  //TODO: add equipment class with shit like durability, have it inhereit from Item class then have weapons and armor inhereit from Equipment class
    {
        public int durability;

        public Equipment(String name, Boolean isLootable, int durability) : base(isLootable, name)
        {
            this.durability = durability;
        }
    }
}
