using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace WindowsGame1.Engine
    {
   public static class InputHandling //catches and processes input.  Called by SceneHandling
        {
           public static KeyboardState keyHandler = new KeyboardState();
            public static KeyboardState oldKeyHanlder = new KeyboardState();
           public static MouseState mouseHandler = new MouseState();
            public static MouseState oldMouseHandler = new MouseState();

       public static void setInputState()
       {
           keyHandler = Keyboard.GetState();
           mouseHandler = Mouse.GetState();
       }

       public static bool inputHasChanged()
       {
           if (keyHandler == oldKeyHanlder && !mouseButtonHasChanged())
           {
               return false;
           }
           return true;
       }

       public static bool mouseButtonHasChanged()
       {
           if (oldMouseHandler.LeftButton == ButtonState.Pressed && mouseHandler.LeftButton == ButtonState.Released)
           {
               return true;
           }
           if (oldMouseHandler.RightButton == ButtonState.Pressed && mouseHandler.RightButton == ButtonState.Released)
           {
               return true;
           }
           return false;
       }

       public static void handleInput()
       {
 
           oldKeyHanlder = keyHandler;
           oldMouseHandler = mouseHandler;
           setInputState();
           switch (SceneHandling.currentScene)
           {
case SceneHandling.Scenes.Splash:
                   if (inputHasChanged())
                   {
                       SceneHandling.advanceScene();
                   }
                   break;

case SceneHandling.Scenes.MainMenu:  //TODO add support for menu and button clicks (add a detector)
                   if (inputHasChanged())
                   {
                       SceneHandling.advanceScene();
                   }
                   break;

case SceneHandling.Scenes.CharacterSelection:
                   if (inputHasChanged())
                   {
                       SceneHandling.advanceScene();
                   }
                   break;

case SceneHandling.Scenes.Ingame:
                   if (inputHasChanged())
                   {
                       SceneHandling.advanceScene();
                   }
                   break;

case SceneHandling.Scenes.Paused:
                   break;

case SceneHandling.Scenes.TESTZONE:
                   break;
           }


       }











        }
    }
