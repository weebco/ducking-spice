using WindowsGame1.Engine.Actors;
using WindowsGame1.Engine.World;

namespace WindowsGame1.Engine.Handlers
    {
   static class GarbageCollection  //c# already has a garbage collector...
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
