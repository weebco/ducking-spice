using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using WindowsGame1.Actors;
using WindowsGame1.Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace WindowsGame1
    {

    public class Main : Microsoft.Xna.Framework.Game
        {
      public static GraphicsDeviceManager graphics;
      public  SpriteBatch spriteBatch;  //not used and can probably remove soon, but leave for now, this is all just default xna code. I offloaded this to a seperate class.

        public Main()
            {
            graphics = new GraphicsDeviceManager(this);  //Resolution must be 4:3 or tiles wont be square, this is easy to fix but it makes more sense to just lock the res options honestly.
            graphics.IsFullScreen = false;         //not all screens are 4:3, and not enabling full screen totally presents that moonrune rpgmaker aesthetic we all know and love
            graphics.PreferredBackBufferHeight = 600;  
            graphics.PreferredBackBufferWidth = 800;
            Engine.MapHandling.setTileSize();
            Content.RootDirectory = "Content";  //not used, we can probably remove soon, but leave for now, this is all just default xna code. Offloaded to ImageLoader.cs
            }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
            {
            // TODO: Add your initialization logic here

            SceneHandling.currentScene = SceneHandling.Scenes.Splash; //set initial screen to splash.  It will do this by default anyway, but just to be safe.
            Engine.Maps.generateMaps();
            base.Initialize();
            }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>



        protected override void LoadContent()  //This section is shit and should be offloaded to ImageLoader.cs otherwise things get really fucking messy
            {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            new ImageLoader(Content);

            // TODO: use this.Content to load your game content here <-- dont believe their lies
            }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
            {
            // TODO: Unload any non ContentManager content here
            }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
            {

            // TODO: Gameloop
            SceneHandling.handleScene();  //the individual gameloops for the different menus etc should go in their own section of processScene()
            InputHandling.setInputState();
            new Actors.Enemy(NavigationPackage.giveCivilianPackage());
            Console.WriteLine("Made an enemy!");


















            base.Update(gameTime);
            }


       
 protected override void Draw(GameTime gameTime)
            {
            GraphicsDevice.Clear(Color.CornflowerBlue);  //this is an ugly color

            // TODO: Draw loop (outsource)
     foreach (Tile tile in Lists.TileList)
     {  
        Lists.RectangleList.Add( new Rectangle(tile.coordX, tile.coordY, MapHandling.tileWidth, MapHandling.tileHeight)); //creates a new rectangle where that tile is and adds it to the list
     }
     foreach (Rectangle rectangle in Lists.RectangleList)
     {
        int position = Lists.RectangleList.IndexOf(rectangle);
     //giant if statement
         if (Lists.TileList.ElementAt(position).tileType == Tile.TileTypes.Black)
         {
             spriteBatch.Draw(null, rectangle, Color.Black);
         }
     }

            base.Draw(gameTime);
            }
        }
    }
