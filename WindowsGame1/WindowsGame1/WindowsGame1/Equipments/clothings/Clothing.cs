using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsGame1.Equipment.clothing
    {
    public  class Clothing
        {
        public enum ClothingType
            {
HAIR,
SHIRT,
PANTS,
PANTY,
SHOES
            }
public ClothingType  clothingType;

public int damage, health, damagePercent;
protected bool isDamaged, isRipped, isBroken, isUnwearable;
public String clothingName;
public int clothId;


public ClothingType getClothingType()
{
return (clothingType);
}

public bool isClothingDamaged(){
return isDamaged;

}







        }

    class Head : Clothing
        {




        }
    }
