using System;
using WindowsGame1.Actors;

namespace WindowsGame1.Engine.Actors
    {
    class Enemy : Actor
        {


        public Enemy(String name, Classes actorClass, NavigationPackage newNavigationPackage) : base(name, actorClass)
        {
            navigationPackage = newNavigationPackage;
            Lists.ActorList.Add(this);
        }

        }
    }
