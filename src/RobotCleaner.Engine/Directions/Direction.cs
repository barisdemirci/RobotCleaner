using System;
using System.Collections.Generic;

namespace RobotCleaner.Engine.Directions
{
    abstract internal class Direction
    {
        public List<Location> CleanedLocations { get; set; } = new List<Location>();

        public int Step { get; set; }

        public bool IsInRange(int point)
        {
            return point < 100000 && point > -100000;
        }

        abstract public List<Location> Clean();
    }
}