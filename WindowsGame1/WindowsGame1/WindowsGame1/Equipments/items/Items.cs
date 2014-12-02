using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace WindowsGame1.Equipments.items
    {
   public class Items
        {
        public Boolean isLootable { get; set; }
        public string name { get; set; }
        public int value { get; set; }
        public Texture2D sprite;


       static public void delete(Items victimItem)
       {
           victimItem = null;
       }
        }
    }
