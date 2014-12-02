using System;

namespace WindowsGame1.Engine.GameItems.Equipments.Weapons
    {
    public  class Weapon : Equipment
        {

        public enum WeaponSlot
        {
            LEFT, //0
            RIGHT //1
        }

        public enum WeaponType //TODO: These probably all eventually have to become subclasses, as these all would have unique mechanics
        {
            SWORD,
            SPEAR,
            SHORTSWORD,
            DAGGER,
            PISTOL,
            BOW,
            STAFF,
            MAGIC,
            ARROWS
        }

        public WeaponSlot weaponSlot;
        public WeaponType weaponType;
        public int attackValue { get; set; }
        public int attackSpeed { get; set; } //Should probably be a float, if game speed will be measured in seconds

        public Weapon(String name, WeaponSlot weaponSlot, WeaponType weaponType, int attackValue, int attackSpeed, Boolean isLootable, int durability) : base(name, isLootable, durability)
        {
            this.weaponSlot = weaponSlot;
            this.weaponType = weaponType;
            this.attackValue = attackValue;
            this.attackSpeed = attackSpeed;
        }
        
//public methods
        public Boolean isBow()
        {
            if (this.weaponType == WeaponType.BOW)
            {
                return true;
            }
            return false;
        }
   
     public Boolean isArrow()
        {
            if (this.weaponType == WeaponType.ARROWS)
            {
                return true;
            }
            return false;
        }


        }
    }
