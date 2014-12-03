using System;
using System.Collections.Generic;
using System.Net.PeerToPeer.Collaboration; //black magic, do not touch
using WindowsGame1.Engine.Actors;
using WindowsGame1.Engine.Game_Objects.World.Tiles;
using WindowsGame1.Engine.World;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


/*HOW TO MAKE A MAP*/
/*
 The map you'll see in game is dynamically generated, and thus doesn't have to be drawn out beforehand. Instead, it's composed from several different, abstract grids.
  First, we'll interpret a simple color grid to layout the basic terrain.  The grid is available in the file system, and colors/tile relations are available in Tile.cs. Colors must be exact!
  Then, make a second map to layout objects. This is non-abstract and is a direct overlay of the to-be generated map.  It has no data on its own and is purely visual 
  then, the collision map must be created.  This is very simple, alpha is passable, black is impassable. Remember to set areas under objects as impassable.
  Finally, the activation map is created.  This is abstract and serves to tell the game where actionable objects are found (these must be drawn in objectmap manually)
TL;DR:
1. Basic Terrain(abstract)
2. Objects (non-abstract)
3. Collision (binary)
4. Activation (abstract)
*/

namespace WindowsGame1.Engine.Handlers
    {
   static class MapHandling
   {

       private static int windowWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
       private static int windowHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
       private static Vector2 gameRes = new Vector2(windowWidth, windowHeight);
       private static uint[] myUint; //for collision sampling
       public static Boolean reDraw = true;        
      public static int coordY, coordX, lastY, lastX, counterX, counterY;

       public static int tileHeight, tileWidth; //these are the same, condense later
       

       public static void setup()
       {

       }

       public static void refreshSize() //call after changing resolution or tiles will still scale to old res
       {
      windowWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
      windowHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
      gameRes = new Vector2(windowWidth, windowHeight);
      setTileSize();  //update tile sizes according to new res
      Actor.updateStep(); //update step size according to new res
//TODO if player is not centered on rectangle, then center him.  needed for if res changes, or errors will accumulate over time
       }

       public static void setTileSize()  //tiles should be 40x40 in 800x600
       {
           tileHeight = windowHeight/15;  //4:3 ratio to preserve tiles as square
           tileWidth = windowWidth/20;
       }

       public static int getTileLength()
       {
           return tileHeight;
       }

       public static void layoutTiles()
       {
           foreach (Tile tile in Lists.TileList)
           {
               tile.isActive = false;
           }
           GarbageCollection.CollectGarbage(); //removes inactive tiles and resets TileList
           Lists.TileList.Clear();//clean out the list to prevent excessive buildup
           int count = 0;
           int totalCount = 20*15; //300. Total number of tiles.
           while (count != totalCount)
           {
               count++;
               Tile tile = new Tile(count);
               Lists.TileList.Add(tile);
           }
           
           foreach (Tile tile in Lists.TileList)   //add elses you fuckwad //Done :^)
           {
               if (!tile.isInitialized)
               {
                   
                   tile.isInitialized = true;
                   tile.isActive = true; //sets tile as active so it isnt removed by garbage collector
                   tile.coordX = tileWidth*counterX;
                   tile.coordY = tileWidth*counterY;
                   counterX++;
                   counterY++;
                   if (counterX > 18)
                   {
                       counterX = 0;
                       counterY++;
                   }

                   tile.coordX -= 20;
                   tile.coordY -= 20; //adjust for xna being stupid and positioning by top-left corner
                   tile.centerCoord.X = tile.coordX + tileWidth/2; // center is at 20x20 relative in 800x600  
                   tile.centerCoord.Y = tile.coordY + tileHeight/2;
                       //maybe ditch this or switch to two int's instead of vector
                   //Sample the color of the collision map at the center point of the tile and determine tile type
                   // ImageLoader.st_00.GetData(0, new Rectangle(tile.coordX+tileWidth/2, tile.coordY+tileHeight/2, 1, 1),myUint , 0, 1);  //set tile type according to data found //TODO: REENABLE
                   //Determine whether tile is passable based on second collision map
                   //Draw tiles on top of everything and unload maps to save memory
               }

           } //end of foreach
           count = 0;
           reDraw = false;
            Console.WriteLine("Done Generating Tiles!");
            Console.WriteLine(Lists.TileList.Count);

       }





           }

       }