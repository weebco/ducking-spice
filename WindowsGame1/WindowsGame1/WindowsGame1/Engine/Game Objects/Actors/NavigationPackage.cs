using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsGame1.Actors
    {
    class NavigationPackage
        {
       public enum PackageTypes 
        {
            NONE,
            STATIC,
            PASSIVE,
            LOCALCHASE,
            MAPCHASE,
            LOCALRANDOM,
            MAPRANDOM
        }
        
        PackageTypes packageType = new PackageTypes();
        private int range;
        private bool hostile;

        public NavigationPackage(PackageTypes newPackageType, int newRange, bool newHostile)
        {
            packageType = newPackageType;
            range = newRange;
            hostile = newHostile;
        }

        //Premade constructors
      static public NavigationPackage giveCivilianPackage()
        {
            return new NavigationPackage(PackageTypes.PASSIVE, 7, false);
        }

      static public NavigationPackage giveStaticPackage()
        {
            return new NavigationPackage(PackageTypes.STATIC, 0, false);
        }







        }
    }
