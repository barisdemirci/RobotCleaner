using System;

namespace RobotCleaner.Engine
{
    internal struct Location : ICloneable
    {
        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }

        public int Y { get; set; }

        public object Clone()
        {
            return new Location()
            {
                X = X,
                Y = Y
            };
        }

        public static bool operator ==(Location c1, Location c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Location c1, Location c2)
        {
            return !c1.Equals(c2);
        }
    }
}