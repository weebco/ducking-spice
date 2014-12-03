using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsGame1.Engine.Game_Objects.World.Tiles.TileTypesNamespace;
using WindowsGame1.Engine.World;
using Microsoft.Xna.Framework.Graphics;

namespace WindowsGame1.Engine.Game_Objects.World.Tiles
    {
    class TileTypes
        {

        public static Texture2D tileTexture;

        public TileTypes()
        {
            
        }

      static  public Texture2D determineTileTexture(Tile tile)
      {
           int localSwitch = (int) tile.tileTypesEnum;
          
            switch (localSwitch)
            {
case  0:
                    return Black.tileTexture;
case 1:
                    return Dirt.tileTexture;
case 2:
                    return Grass.tileTexture;
case 3:
                    return Road.tileTexture;
case 4:
                    return Sand.tileTexture;
case 5:
                    return ShallowWater.tileTexture;
case 6:
                    return Wall.tileTexture;
case 7:
                    return Water.tileTexture;
            }
            return null;
        }
        }
    }
