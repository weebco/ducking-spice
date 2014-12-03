using System;
using WindowsGame1.Actors;
using WindowsGame1.Engine.GameItems.Equipments.Armors;
using WindowsGame1.Engine.GameItems.Equipments.Weapons;
using WindowsGame1.Engine.Handlers;
using Microsoft.Xna.Framework.Graphics;

namespace WindowsGame1.Engine.Actors //"entities" make it sound like sci fi.  "actors" encompasses that perfect mix where you arent quite sure if its an rpgmaker rip off or a porno
	{
	class Actor
	{
	public Texture2D sprite; //Single sprite for now.

	//armor slots
	public Armor[] ArmorSlotsArray = new Armor[5];
	// 0=aesthetic, 1=head 2=chest 3=gauntlets 4=boots    This will probably change
	public Weapon[] WeaponSlotsArray = new Weapon[2];
	// 0=left, 1=right   This will probably not change
	    public NavigationPackage navigationPackage;

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

//Fields
		public String name { get; set; }
		public int actorID { get; set; }
		public int currentHP { get; set; }
		public int maxHP { get; set; }
		public int gold { get; set; }
		static public int STEP = MapHandling.getTileLength();
//Bools
		public Boolean active { get; set; }
		public Boolean alive { get; set; }
		public Boolean male { get; set; }
		public Boolean isPlayer { get; set; }
		public Boolean heavyTrained = false; //able to equip heavy armor
		public Boolean gunTrained = false; //able to use firearms

//Constructor
	    public Actor(String name, Classes actorClass) //Dummy constructor, flesh out later
	    {
	        this.name = name;
	        this.actorClass = actorClass;
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
		    if (Lists.ActorList.Remove(victimActor))
		    {
                Console.WriteLine("Successfully removed entity from ActorList: " + victimActor.ToString());
		    }
		    else
		    {
                Console.WriteLine("Error removing entity: " + victimActor.ToString());
		    }
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

        //Overrides default ToString for debugging purposes
	    new public String ToString()
	    {
	        return "name: " + this.name + " ID: " + this.actorID.ToString();
	    }







		}
	}
