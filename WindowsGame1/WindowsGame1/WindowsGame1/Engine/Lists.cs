using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsGame1.Actors;
using WindowsGame1.Equipments.armors;

namespace WindowsGame1.Engine
    {
    static class Lists
        {
        public  static  List<Tile> TileList = new List<Tile>();
       static public     List<Actors.Actor> ActorList = new List<Actor>();
        public static List<Armor.ArmorTypes> ArmorTypesList = new List<Armor.ArmorTypes>();
        public static List<object> InventoryList = new List<object>();
        }
    }
