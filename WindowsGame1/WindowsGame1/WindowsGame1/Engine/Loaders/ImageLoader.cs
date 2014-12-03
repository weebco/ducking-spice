using System;
using System.Threading;
using WindowsGame1.Engine.Actors;
using WindowsGame1.Engine.GameItems;
using WindowsGame1.Engine.Game_Objects.World.Tiles;
using WindowsGame1.Engine.Game_Objects.World.Tiles.TileTypesNamespace;
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
            foreach (Screens screen in Lists.ScreenList) //Splash, main menu background, stuff like that
            {
                try
                {
                    screen.screenTexture = content.Load<Texture2D>("Screens/" + screen.screenName);
                    Console.WriteLine("Loaded Screen: " + screen.screenName);
                }
                catch
                {
                    Console.WriteLine("Screen: " + screen.screenName + " has failed to load!");
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
                    Console.WriteLine("Loaded Item: " + item.name);
                }
                catch
                {
                    Console.WriteLine("Item: " + item.name + " has failed to load!");
                    //FNF
                }
                
            }


      
                String tileDir = "Tiles/";
                Game_Objects.World.Tiles.TileTypesNamespace.Black.tileTexture =
                    content.Load<Texture2D>(tileDir + Black.name);
                Game_Objects.World.Tiles.TileTypesNamespace.Dirt.tileTexture =
                    content.Load<Texture2D>(tileDir + Dirt.name);
                Game_Objects.World.Tiles.TileTypesNamespace.Grass.tileTexture =
                    content.Load<Texture2D>(tileDir + Grass.name);
                Game_Objects.World.Tiles.TileTypesNamespace.Road.tileTexture =
                    content.Load<Texture2D>(tileDir + Road.name);
                Game_Objects.World.Tiles.TileTypesNamespace.Sand.tileTexture =
                    content.Load<Texture2D>(tileDir + Sand.name);
                Game_Objects.World.Tiles.TileTypesNamespace.ShallowWater.tileTexture =
                    content.Load<Texture2D>(tileDir + ShallowWater.name);
                Game_Objects.World.Tiles.TileTypesNamespace.Wall.tileTexture =
                    content.Load<Texture2D>(tileDir + Wall.name);
                Game_Objects.World.Tiles.TileTypesNamespace.Water.tileTexture =
                    content.Load<Texture2D>(tileDir + Water.name);



            foreach (Actor actor in Lists.ActorList) //ACTOR LOADING
            {
                try
                {
                    if (actor.isPlayer)
                    {
                        actor.sprite = content.Load<Texture2D>("Actors/playersprite");
                    Console.WriteLine("Loaded Player Sprite");
                    }
                    else
                    {
                        actor.sprite = content.Load<Texture2D>("Actors/" + actor.name);
                    Console.WriteLine("Loaded Actor Sprite: " + actor.name);
                    }
                }
                catch
                {
                    Console.WriteLine("Actor: " + actor.name + " has failed to load!");

                    //FNF
                }
            }
 
Console.WriteLine("Finished loading content!");
        }



    }
}