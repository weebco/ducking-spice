using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsGame1.Actors;
using WindowsGame1.Equipments.armors;
using WindowsGame1.Equipments.items;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WindowsGame1.Engine
{
    internal static class Lists //arrays are for gays
    {
        public static List<Tile> TileList = new List<Tile>();
        public static List<Rectangle> RectangleList = new List<Rectangle>();
        public static List<Actors.Actor> ActorList = new List<Actor>();
        public static List<Armor.ArmorTypes> ArmorTypesList = new List<Armor.ArmorTypes>();
        public static List<Items> InventoryList = new List<Items>();
        public static List<Maps> MapList = new List<Maps>();
    }
}