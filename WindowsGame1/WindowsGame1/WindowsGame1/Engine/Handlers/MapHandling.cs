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


              //     tile.tileType.tileTypesEnum = TileTypes.TileTypesEnum.Black;

                   tile.isActive = true; //sets tile as active so it isnt removed by garbage collector
                   //First, determine y coordinates in the most verbose manner humanly possible
                   if (tile.position < 21) //All values assume a height of 600, but should work regardless
                   {
                       tile.coordY = windowHeight/30; //20
                   }
                   else if (tile.position > 20 && tile.position < 41)
                   {
                       tile.coordY = windowHeight/15 + windowHeight/30; //60
                   }
                   else if (tile.position > 40 && tile.position < 61)
                   {
                       tile.coordY = windowHeight/15*2 + windowHeight/30; //100
                   }
                   else if (tile.position > 60 && tile.position < 81)
                   {
                       tile.coordY = windowHeight/15*3 + windowHeight/30; //140
                   }
                   else if (tile.position > 80 && tile.position < 101)
                   {
                       tile.coordY = windowHeight/15*4 + windowHeight/30; //180
                   }
                   else if (tile.position > 100 && tile.position < 121)
                   {
                       tile.coordY = windowHeight/15*5 + windowHeight/30; //220
                   }
                   else if (tile.position > 120 && tile.position < 141)
                   {
                       tile.coordY = windowHeight/15*6 + windowHeight/30; //260
                   }
                   else if (tile.position > 140 && tile.position < 161)
                   {
                       tile.coordY = windowHeight/15*7 + windowHeight/30; //300
                   }
                   else if (tile.position > 160 && tile.position < 181)
                   {
                       tile.coordY = windowHeight/15*8 + windowHeight/30; //340
                   }
                   else if (tile.position > 180 && tile.position < 201)
                   {
                       tile.coordY = windowHeight/15*9 + windowHeight/30; //380
                   }
                   else if (tile.position > 200 && tile.position < 221)
                   {
                       tile.coordY = windowHeight/15*10 + windowHeight/30; //420
                   }
                   else if (tile.position > 220 && tile.position < 241)
                   {
                       tile.coordY = windowHeight/15*11 + windowHeight/30; //460
                   }
                   else if (tile.position > 240 && tile.position < 261)
                   {
                       tile.coordY = windowHeight/15*12 + windowHeight/30; //500
                   }
                   else if (tile.position > 260 && tile.position < 281)
                   {
                       tile.coordY = windowHeight/15*13 + windowHeight/30; //540
                   }
                   else if (tile.position > 280 && tile.position < 301)
                   {
                       tile.coordY = windowHeight/15*14 + windowHeight/30; //580
                   }
//Now, do the same for x coordinates
                   if (tile.position < 16) //All values assume a width of 800, but should work regardless
                   {
                       tile.coordX = windowHeight/40; //20
                   }
                   else if (tile.position > 15 && tile.position < 31)
                   {
                       tile.coordX = windowHeight/20 + windowHeight/40; //60
                   }
                   else if (tile.position > 15 && tile.position < 31)
                   {
                       tile.coordX = windowHeight/20*2 + windowHeight/40; //100
                   }
                   else if (tile.position > 30 && tile.position < 46)
                   {
                       tile.coordX = windowHeight/20*3 + windowHeight/40; //140
                   }
                   else if (tile.position > 45 && tile.position < 61)
                   {
                       tile.coordX = windowHeight/20*4 + windowHeight/40; //180
                   }
                   else if (tile.position > 60 && tile.position < 76)
                   {
                       tile.coordX = windowHeight/20*5 + windowHeight/40; //220
                   }
                   else if (tile.position > 75 && tile.position < 91)
                   {
                       tile.coordX = windowHeight/20*6 + windowHeight/40; //260
                   }
                   else if (tile.position > 90 && tile.position < 106)
                   {
                       tile.coordX = windowHeight/20*7 + windowHeight/40; //300
                   }
                   else if (tile.position > 105 && tile.position < 121)
                   {
                       tile.coordX = windowHeight/20*8 + windowHeight/40; //340
                   }
                   else if (tile.position > 120 && tile.position < 136)
                   {
                       tile.coordX = windowHeight/20*9 + windowHeight/40; //380
                   }
                   else if (tile.position > 135 && tile.position < 151)
                   {
                       tile.coordX = windowHeight/20*10 + windowHeight/40; //420
                   }
                   else if (tile.position > 150 && tile.position < 166)
                   {
                       tile.coordX = windowHeight/20*11 + windowHeight/40; //460
                   }
                   else if (tile.position > 165 && tile.position < 181)
                   {
                       tile.coordX = windowHeight/20*12 + windowHeight/40; //500
                   }
                   else if (tile.position > 180 && tile.position < 196)
                   {
                       tile.coordX = windowHeight/20*13 + windowHeight/40; //540
                   }
                   else if (tile.position > 195 && tile.position < 211)
                   {
                       tile.coordX = windowHeight/20*14 + windowHeight/40; //580
                   }
                   else if (tile.position > 210 && tile.position < 226)
                   {
                       tile.coordX = windowHeight/20*15 + windowHeight/40; //620
                   }
                   else if (tile.position > 225 && tile.position < 241)
                   {
                       tile.coordX = windowHeight/20*16 + windowHeight/40; //660
                   }
                   else if (tile.position > 240 && tile.position < 256)
                   {
                       tile.coordX = windowHeight/20*17 + windowHeight/40; //700
                   }
                   else if (tile.position > 255 && tile.position < 271)
                   {
                       tile.coordX = windowHeight/20*18 + windowHeight/40; //740
                   }
                   else if (tile.position > 270 && tile.position < 286)
                   {
                       tile.coordX = windowHeight/20*19 + windowHeight/40; //780
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