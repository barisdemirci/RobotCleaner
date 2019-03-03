using System;
using System.Collections.Generic;
using System.Text;

namespace RobotCleaner.Engine.Directions
{
    internal class West : Direction
    {
        public override List<Location> Clean()
        {
            for (int j = 0; j < Step; j++)
            {
                Location candidateLocation = new Location(Robot.Location.X - 1, Robot.Location.Y);
                if (IsInRange(candidateLocation.X))
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