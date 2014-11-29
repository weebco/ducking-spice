using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsGame1.Equipments.armors
    {
    public  class Weapon : items.Items
        {



        public enum WeaponSlot
        {
            LEFT, //0
            RIGHT //1
        }

        public enum WeaponType
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
        public int attackSpeed { get; set; }
        
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
