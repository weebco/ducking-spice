using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsGame1.Equipments.items
    {
   public class Items
        {
        public Boolean isLootable { get; set; }
        public string name { get; set; }
        public int value { get; set; }


       static public void delete(Items victimItem)
       {
           victimItem = null;
       }
        }
    }
