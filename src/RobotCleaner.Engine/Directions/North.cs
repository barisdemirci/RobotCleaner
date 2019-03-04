using System;
using System.Collections.Generic;
using System.Text;

namespace RobotCleaner.Engine.Directions
{
    internal class North : Direction
    {
        public override List<Location> Clean()
        {
            for (int i = 0; i < Step; i++)
            {
                Location candidateLocation = new Location(Robot.Location.X, Robot.Location.Y + 1);
                if (IsInRange(candidateLocation.Y))
                {
                    CleanedLocations.Add(candidateLocation);
                    Robot.Location = candidateLocation;
                }
                else
                {
                    break;
                }
            }

            return CleanedLocations;
        }
    }
}