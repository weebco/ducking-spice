using System;
using Microsoft.Xna.Framework.Graphics;

namespace WindowsGame1.Engine.GameItems
    {
   public class Items
        {
        public Boolean isLootable { get; set; }
        public string name { get; set; }
        public int value { get; set; }
        public Texture2D sprite;


       public Items(Boolean isLootable, String name)
       {
           this.isLootable = isLootable;
           this.name = name;
       }

       static public void delete(Items victimItem)
       {
           victimItem = null;
       }
        }
    }
