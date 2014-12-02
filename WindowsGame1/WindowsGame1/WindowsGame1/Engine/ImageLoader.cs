using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using WindowsGame1.Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace WindowsGame1
{
    class ImageLoader
    {
        public static Texture2D st_00;
        public ImageLoader(ContentManager content)
        {
            content.RootDirectory = "Content";
            st_00 = content.Load<Texture2D>("Maps/st_00");
            foreach (Maps map in Lists.MapList)
            {
                 map.terrainMap = content.Load<Texture2D>("Maps/" + map.mapId);
            }


                
        }
    }
}