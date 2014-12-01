using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsGame1.Engine;
using WindowsGame1.Equipments.armors;

namespace WindowsGame1.Actors //"entities" make it sound like sci fi.  "actors" encompasses that perfect mix where you arent quite sure if its an rpgmaker rip off or a porno
	{
	class Actor
		{
	//armor slots
	public Armor[] ArmorSlotsArray = new Armor[4];
	// 0=aesthetic, 1=head 2=chest 3=gauntlets 4=boots    This will probably change
	public Weapon[] WeaponSlotsArray = new Weapon[1];
	// 0=left, 1=right   This will probably not change

		public enum Classes
		{
			ARCHER,  //bows
			SABER,  //swords
			LANCER,  //Spears
			CASTER,  //magic
			BERSERKER,  //Fists 
			ASSASSIN,  //knives
			DUELIST,  //pistols
			SOLDIER,   //mix of all
			SNIPER   //rifles
		}
		Classes actorClass { get; set; }

// statics
		public static int FirstTimeBow = 0;  //pops up a reminder to equip arrows the first couple of times

//Fields
		public String Name { get; set; }
		public int HP { get; set; }
		public int Health { get; set; }
		public int gold { get; set; }
	    static public int STEP = MapHandling.getTileLength();
//Bools
		public Boolean active { get; set; }
		public Boolean alive { get; set; }
		public Boolean male { get; set; }
		public Boolean isPlayer { get; set; }
		public Boolean heavyTrained = false; //able to equip heavy armor
		public Boolean gunTrained = false; //able to use firearms


//Equip Methods

		public static void equipOn(Actor targetActor, Armor.ArmorSlot slot,  Armor targetArmor )
		{
		 int targetSlot = (int) slot;
			//check for compatability
			if (targetArmor.armorSlot != slot)
			{
				Console.WriteLine("This doesn't go here!");
				return;
			}
			if (targetArmor.armorType == Armor.ArmorTypes.HEAVY && isHeavyTrained(targetActor))
			if (targetActor.ArmorSlotsArray[targetSlot] != null)  //unequip existing item
			{
			Lists.InventoryList.Add(targetActor.ArmorSlotsArray[targetSlot]);
			Console.WriteLine( targetActor.ArmorSlotsArray[targetSlot].name + " has been returned to Inventory.");  
			}
			targetActor.ArmorSlotsArray[targetSlot] = targetArmor;
			Lists.InventoryList.Remove(targetArmor);
		}


		public static void equipOn(Actor targetActor, Weapon.WeaponSlot slot,  Weapon targetWeapon )
		{
		 int targetSlot = (int) slot;
			//check for compatability
			if (targetWeapon.weaponSlot != slot)
			{
				Console.WriteLine("This doesn't go here!");
				return;
			}
			if (targetActor.WeaponSlotsArray[targetSlot] != null)  //unequip existing item
			{
			Lists.InventoryList.Add(targetActor.WeaponSlotsArray[targetSlot]);
			Console.WriteLine( targetActor.WeaponSlotsArray[targetSlot].name + " has been returned to Inventory.");  
			}
		
			targetActor.WeaponSlotsArray[targetSlot] = targetWeapon;
			if (FirstTimeBow < 3 && targetWeapon.isBow() && !targetActor.isArrowsEquipped())  //remind new player to equip arrows with bow
			{
				Console.WriteLine("I'm going to need arrows to use this...");
				FirstTimeBow++;
			}
			Lists.InventoryList.Remove(targetWeapon);
		 
		}


//Other Public Methods
		public int calculateArmorValue()
		{
			int armorValue = 0;
			foreach (Armor equippedArmor in ArmorSlotsArray)
			{
			   armorValue += equippedArmor.armorValue;
			}
			return armorValue;
		}


		static public void delete(Actor victimActor)
		{
			victimActor = null;
		}

	    static public void updateStep()
	    {
	        STEP = MapHandling.getTileLength();
	    }


//Boolean Methods

		public Boolean isArrowsEquipped()
		{
			if (this.WeaponSlotsArray[1].weaponType == Weapon.WeaponType.ARROWS)
			{
				return true;
			}
			return false;
		}

		public static Boolean isHeavyTrained(Actor targetActor)
		{
			if ((targetActor.isPlayer && targetActor.heavyTrained) || !targetActor.isPlayer)
			{
				return true;
			}
			return false;
		}









		}
	}
