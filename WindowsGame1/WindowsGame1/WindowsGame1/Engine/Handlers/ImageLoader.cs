﻿using System;
using WindowsGame1.Engine.Actors;
using WindowsGame1.Engine.GameItems;
using WindowsGame1.Engine.World;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace WindowsGame1.Engine.Handlers
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
            //^ DONE: add an item list and put it here.  Inventory list is just for inventory and happens to be of type item cause of that
            //TODO: add equipment class with shit like durability, have it inhereit from Item class then have weapons and armor inhereit from Equipment class
            foreach (Items item in Lists.ItemList) //ITEM SPRITE LOADING
            {
                try
                {
                    item.sprite = content.Load<Texture2D>("Items/" + item.name); //Guessing future name of the directory, change later if necessary
                }
                catch
                {
                    Console.WriteLine("Item: " + item.name + " has failed to load!");
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
                    Console.WriteLine("Actor: " + actor.name + " has failed to load!");

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
                    Console.WriteLine("Salamander *Wiggle*");
                    //FNF
                }
            }
Console.WriteLine("Finished loading content!");
        }
    }
}