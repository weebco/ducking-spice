using System;
using System.Collections.Generic;
using WindowsGame1.Engine.GameItems;
using WindowsGame1.Engine.GameItems.Equipments.Armors;
using WindowsGame1.Engine.GameItems.Equipments.Weapons;

namespace WindowsGame1.Engine.Actors
    {
        class Player : Actor
        {
            public int maxInventorySize;
            public static List<Items> Inventory = new List<Items>();
            
            // statics
            public static int FirstTimeBow = 0;  //pops up a reminder to equip arrows the first couple of times
                                                //Only useful for players, moved to player class

            public Player(String name, Classes actorClass, int maxInventorySize) : base(name, actorClass) //base calls parent's constructor with the provided args
            {
                this.maxInventorySize = maxInventorySize;
            }

            //Equip Methods
            //Only useful for players, enemies can have their equipment predefined without these methods
            public static void equipOn(Actor targetActor, Armor.ArmorSlot slot, Armor targetArmor)
            {
                int targetSlot = (int)slot;
                //check for compatability
                if (targetArmor.armorSlot != slot)
                {
                    Console.WriteLine("This doesn't go here!");
                    return;
                }
                if (targetArmor.armorType == Armor.ArmorTypes.HEAVY && isHeavyTrained(targetActor))
                    if (targetActor.ArmorSlotsArray[targetSlot] != null)  //unequip existing item
                    {
                        Inventory.Add(targetActor.ArmorSlotsArray[targetSlot]);
                        Console.WriteLine(targetActor.ArmorSlotsArray[targetSlot].name + " has been returned to Inventory.");
                    }
                targetActor.ArmorSlotsArray[targetSlot] = targetArmor;
                Inventory.Remove(targetArmor);
            }


            public static void equipOn(Actor targetActor, Weapon.WeaponSlot slot, Weapon targetWeapon)
            {
                int targetSlot = (int)slot;
                //check for compatability
                if (targetWeapon.weaponSlot != slot)
                {
                    Console.WriteLine("This doesn't go here!");
                    return;
                }
                if (targetActor.WeaponSlotsArray[targetSlot] != null)  //unequip existing item
                {
                    Inventory.Add(targetActor.WeaponSlotsArray[targetSlot]);
                    Console.WriteLine(targetActor.WeaponSlotsArray[targetSlot].name + " has been returned to Inventory.");
                }

                targetActor.WeaponSlotsArray[targetSlot] = targetWeapon;
                if (FirstTimeBow < 3 && targetWeapon.isBow() && !targetActor.isArrowsEquipped())  //remind new player to equip arrows with bow
                {
                    Console.WriteLine("I'm going to need arrows to use this...");
                    FirstTimeBow++;
                }
                Inventory.Remove(targetWeapon);
            }
        }
    }
