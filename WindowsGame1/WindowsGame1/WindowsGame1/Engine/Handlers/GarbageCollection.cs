using System;
using WindowsGame1.Engine.Actors;
using WindowsGame1.Engine.World;

namespace WindowsGame1.Engine.Handlers
    {
   static class GarbageCollection  //c# already has a garbage collector...
        {

       public static void CollectGarbage()
       {
        Console.WriteLine("Collecting Garbage...");
 Console.WriteLine("Tile List was: " + Lists.TileList.Count);
           foreach ( Tile tile in Lists.TileList)
           {       
               if (!tile.isActive)
               {
                Lists.victimTileList.Add(tile);
               }
 
           }
           foreach (Tile tile in Lists.victimTileList)
           {
               Lists.TileList.Remove(tile);
               tile.delete(tile);
           }
            Lists.victimTileList.Clear();
                   
  Console.WriteLine("Actor List was: " + Lists.ActorList.Count);
           foreach (Actor actor in Lists.ActorList)
           {      
               if (!actor.active)
               {
                   Lists.ActorList.Remove(actor);
                   Actor.delete(actor);
               }
           }
    Console.WriteLine("Finished collecting garbage.  Tile and Actor lists are now respectively: " + Lists.TileList.Count + " " + Lists.ActorList.Count);
       }    


        }
    }
