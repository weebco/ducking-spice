using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

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
        int position;

        public Tile(TileTypes thisTileType, int thisPosition)
        {
            tileType = thisTileType;
            isActive = true;
            Lists.TileList.Add(this);
            position = thisPosition;
        }

       static public void delete(Tile victimTile )
        {
            victimTile = null;
        }


    }
    }
