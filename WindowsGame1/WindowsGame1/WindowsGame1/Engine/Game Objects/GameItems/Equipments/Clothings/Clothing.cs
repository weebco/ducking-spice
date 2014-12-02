using System;

namespace WindowsGame1.Engine.GameItems.Equipments.Clothings  //deprecated, redo entirely
{
    public class Clothing
    {
        public enum ClothingType
        {
            HAIR,
            SHIRT,
            PANTS,
            SHOES
        }

        public ClothingType clothingType;

        public int damage, health, damagePercent;
        protected bool isUnwearable;
        public String clothingName;
        public int clothId;


        public ClothingType getClothingType()
        {
            return (clothingType);
        }

    }


    }
