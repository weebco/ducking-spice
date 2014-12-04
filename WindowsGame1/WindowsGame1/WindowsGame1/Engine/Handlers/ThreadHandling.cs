using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace WindowsGame1.Engine.Handlers
    {
   public static class ThreadHandling
        {
            
           public static Thread tile1Thread = new Thread(new ThreadStart(MapHandling.layoutTiles1));
           public static Thread tile2Thread = new Thread(new ThreadStart(MapHandling.layoutTiles2));
           public static Thread tile3Thread = new Thread(new ThreadStart(MapHandling.layoutTiles3));
           public static Thread tile4Thread = new Thread(new ThreadStart(MapHandling.layoutTiles4));

       public static void newThread(System.Action action)
       {
                      Thread wanderingThread = new Thread(new ThreadStart(action));

       }

        
        }
    }
