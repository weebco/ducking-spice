using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using Microsoft.Xna.Framework.Net;

namespace WindowsGame1.Engine
    {
    class Maps
    {
        public string mapName; //display
        public string mapId; //internal. 
        public Boolean hasCollisionMap;
        public Boolean hasObjectMap;
        public Boolean hasActorMap;




        public void generateMaps()  //preload all maps, this is gonna get long so maybe offload later?
        {
            string name;
            string id;
            name = "start";
            id = "st_00";

            new Maps(name, id, false, false, false);
        }

        public Maps(string newMapName, string newMapId, bool collisionMap, bool objectMap, bool actorMap)
        {
            mapName = newMapName;
            mapId = newMapId;
            Lists.MapList.Add(this);
            hasCollisionMap = collisionMap;
            hasObjectMap = objectMap;
            hasActorMap = actorMap;
        }

 
    }
    }
