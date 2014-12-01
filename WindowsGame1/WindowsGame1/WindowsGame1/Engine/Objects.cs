using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsGame1.Engine
{
    internal class Objects
    {
        public enum ObjectTypes
        {
            DOOR,
            BENCHLEFT,
            BENCHRIGHT,
        }

        public ObjectTypes objectType { get; set; }
        public Boolean activable { get; set; }
    }
}