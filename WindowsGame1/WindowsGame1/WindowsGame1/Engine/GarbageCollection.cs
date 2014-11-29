using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsGame1.Engine
    {
   static class GarbageCollection
        {

       public static void CollectGarbage()
       {
           foreach ( Tile tile in Lists.TileList)
           {
               if (!tile.isActive)
               {
                   Lists.TileList.Remove(tile);
               }
               Tile.delete(tile);
           }

       }


        }
    }
