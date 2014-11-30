using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsGame1.Actors;

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
                   Tile.delete(tile);
               }
           }
           foreach (Actor actor in Lists.ActorList)
           {
               if (!actor.active)
               {
                   Lists.ActorList.Remove(actor);
                   Actor.delete(actor);
               }
           }

       }


        }
    }
