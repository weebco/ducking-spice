using System;

namespace WindowsGame1.Engine.World
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