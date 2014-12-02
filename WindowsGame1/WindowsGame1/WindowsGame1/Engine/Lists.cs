using System.Collections.Generic;
using WindowsGame1.Engine.Actors;
using WindowsGame1.Engine.GameItems;
using WindowsGame1.Engine.GameItems.Equipments.Armors;
using WindowsGame1.Engine.World;
using Microsoft.Xna.Framework;

namespace WindowsGame1.Engine
{
    internal static class Lists //arrays are for gays
    {
        public static List<Tile> TileList = new List<Tile>();
        public static List<Rectangle> RectangleList = new List<Rectangle>();
        public static List<Actors.Actor> ActorList = new List<Actor>();
        public static List<Armor.ArmorTypes> ArmorTypesList = new List<Armor.ArmorTypes>();
        public static List<Items> ItemList = new List<Items>();
        public static List<Maps> MapList = new List<Maps>();
    }
}