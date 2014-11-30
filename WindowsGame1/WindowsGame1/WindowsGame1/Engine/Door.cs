using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsGame1.Engine
   {
    class Door : Objects
    {
        public Maps targetMap;

        public enum LockedTypes
        {
            LOCKED,
            KEYLOCKED,
            UNLOCKED
        }
        public LockedTypes lockedType = LockedTypes.UNLOCKED;

        public Boolean isLocked()
        {
            if (lockedType == LockedTypes.UNLOCKED)
            {
                return false;
            }
            return true;
        }
        
      

    }
   }
