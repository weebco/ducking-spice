using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Text;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace WindowsGame1.Engine
    {
   static class MapHandling
   {

       private static int windowWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
       private static int windowHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
       private static Vector2 gameRes = new Vector2(windowWidth, windowHeight);

       public static int tileHeight, tileWidth;


       public static void setup()
       {

       }

       public static void refreshSize() //call after changing resolution or tiles will still scale to old res
       {
      windowWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
      windowHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
      gameRes = new Vector2(windowWidth, windowHeight);
      setTileSize();  //update tile sizes according to new res
       }

       public static void setTileSize()
       {
           tileHeight = windowHeight/15;  //4:3 ratio to preserve tiles as square
           tileWidth = windowWidth/20;
       }

       public static void layoutTiles()
       {
           int count = 0;
           int totalCount = 15*20; //300. Total number of tiles.
           List<Tile> tileList = new List<Tile>();
           while (count != totalCount)
           {
             count++;
            Tile tile = new Tile(count);
            tileList.Add(tile);
           }
           foreach (Tile tile in tileList)
           {
               if (tile.position < 16)
               {
                   tile.coordY = windowHeight/30;
               }
               if (tile.position > 15 && tile.position < 31)
               {
                   tile.coordY = windowHeight/15 + windowHeight/30;
               }
               if (tile.position > 30 && tile.position < 46)
               {
                   tile.coordY = windowHeight/15*2 + windowHeight/30;
               }
               if (tile.position > 45 && tile.position < 61)
               {
                   tile.coordY = ;
               }
               if (tile.position > 60 && tile.position < 76)
               {
                   tile.coordY = ;
               }
           }


       }





   }
    }
