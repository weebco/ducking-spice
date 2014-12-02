using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using WindowsGame1.Actors;
using WindowsGame1.Engine;
using WindowsGame1.Equipments.items;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace WindowsGame1
{
    class ImageLoader
    {
        public static Texture2D st_00;
        public  ImageLoader(ContentManager content) //We -probably- need to add file extensions to these  <-- definitely dont do this 
        {
            Console.WriteLine("Now loading content...");
            content.RootDirectory = "Content";
            foreach (Maps map in Lists.MapList) //MAPLOADING
            {
                try
                {
                    map.terrainMap = content.Load<Texture2D>("Maps/" + map.mapId);
                    Console.WriteLine("Loaded Map: " + map.mapId);
                }
                catch
                {
                    Console.WriteLine("Map: " + map.mapId + " has failed to load!");
                    //FNF. ignoring for now.
                }
                 
            }

            //Looks like armor is of type item, so loading all the items in the InventoryList should load the sprites for all the armors as well...
            foreach (Items item in Lists.InventoryList) //ITEM SPRITE LOADING
            {
                try
                {
                    item.sprite = content.Load<Texture2D>("Items/" + item.name); //Guessing future name of the directory, change later if necessary
                }
                catch
                {
                    Console.WriteLine("Item: " +item.name + " has failed to load!");
                    //FNF
                }
                
            }

            foreach (Actor actor in Lists.ActorList) //ACTOR LOADING
            {
                try
                {
                    if (actor.isPlayer)
                    {
                        actor.sprite = content.Load<Texture2D>("Actors/playersprite");
                    }
                    else
                    {
                        actor.sprite = content.Load<Texture2D>("Actors/" + actor.name);
                    }
                }
                catch
                {
                    Console.WriteLine("Actor: " +actor.name + " has failed to load!");

                    //FNF
                }
            }
            //It would be much more efficient to only load each tile type once and render it multiple times rather than loading the sprite for every instance of the tile.
            //This would be done with a Hashtable of TileTypes mapped to Texture2Ds.
            foreach (Tile tile in Lists.TileList) 
            {
                try
                {
                    tile.sprite = content.Load<Texture2D>("Tiles/" + tile.tileType); //This doesn't work as intended, but tile loaded obv should be based on assigned enum value
                }
                catch
                {
                    //FNF
                }
            }
Console.WriteLine("Finished loading content!");
        }
    }
}