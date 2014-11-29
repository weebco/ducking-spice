using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Text;
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






   }
    }
