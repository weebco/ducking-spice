﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsGame1.Actors;
using WindowsGame1.Equipments.armors;
using WindowsGame1.Equipments.items;

namespace WindowsGame1.Engine
    {
    static class Lists //arrays are for gays
        {
        public  static  List<Tile> TileList = new List<Tile>();
       static public     List<Actors.Actor> ActorList = new List<Actor>();
        public static List<Armor.ArmorTypes> ArmorTypesList = new List<Armor.ArmorTypes>();
        public static List<Items> InventoryList = new List<Items>();
  
        }
    }
