using System;
using System.Collections.Generic;
using System.Linq;
using RobotCleaner.Engine.Directions;

namespace RobotCleaner.Engine
{
    public class Robot
    {
        internal static Location Location;
        private List<Direction> commands;

        public Robot(string locationOfRobot, List<string> commands)
        {
            Location = new Location();
            Location.X = int.Parse(locationOfRobot.Split(" ")[0]);
            Location.Y = int.Parse(locationOfRobot.Split(" ")[1]);
            this.commands = new List<Direction>();
            foreach (var item in commands)
            {
                Direction direction = GetInstance(item.Split(" ")[0]);
                direction.Step = int.Parse(item.Split(" ")[1]);
                this.commands.Add(direction);
            }
        }

        internal List<Location> CleanedLocations { get; set; } = new List<Location>();

        public void Start()
        {
            CleanedLocations.Add(Location);

            for (int i = 0; i < commands.Count; i++)
            {
                List<Location> cleanedLocations = commands[i].Clean();
                CleanedLocations.AddRange(cleanedLocations);
            }
        }

        public int CountOfUniqueLocations()
        {
            List<Location> uniqueLocations = new List<Location>();
            foreach (var location in CleanedLocations)
            {
                if (!uniqueLocations.Contains(location))
                {
                    uniqueLocations.Add(location);
                }
            }
            return uniqueLocations.Count;
        }

        private Direction GetInstance(string directionString)
        {
            Direction direction = null;
            switch (directionString)
            {
                case "E":
                    direction = new East();
                    break;
                case "W":
                    direction = new West();
                    break;
                case "N":
                    direction = new North();
                    break;
                case "S":
                    direction = new South();
                    break;
            }

            return direction;
        }
    }
}