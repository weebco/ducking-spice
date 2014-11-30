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
            Grass,        //76,255,0
            Dirt,         //127,51,0
            Road,         //128,128,128
            Sand,         //255,255
            Water,        //0,0,255
            ShallowWater, //0,255,255
            Wall,         //64,64,64
            Black         //0,0,0
        };

        public Boolean isActive = false;
        public Boolean isPassable = false;
        public Boolean isEventTrigger = false;
        public int eventId = 0;
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

        public void setPassable(Tile targetTile)
        {
            targetTile.isPassable = true;
        }

        public void setEvent(Tile targetTile, int targetEventId)
        {
            targetTile.isEventTrigger = true;
            targetTile.eventId = targetEventId;
        }

    }
    }
