using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsGame1.Equipment.clothing  //deprecated, redo entirely
    {
    public  class Clothing
        {
        public enum ClothingType
            {
HAIR,
SHIRT,
PANTS,
SHOES
            }
public ClothingType  clothingType;

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
