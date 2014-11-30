using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace WindowsGame1.Engine
    {
    class Tile
    {

        public enum TileTypes
        {
            Grass,
            Dirt,
            Road
        };

        public Boolean isActive = false;
        public TileTypes tileType;
        public int position;
        public int coordX, coordY;
        public int tileSizeX, tileSizeY;
        public Vector2 centerCoord = new Vector2();

        public Tile(TileTypes thisTileType, int thisPosition)
        {
            tileType = thisTileType;
            isActive = true;
            Lists.TileList.Add(this);
            position = thisPosition;
        }

        public Tile(int newPosition)
        {
            position = newPosition;
        }


       static public void delete(Tile victimTile )
        {
            victimTile = null;
        }


    }
    }
