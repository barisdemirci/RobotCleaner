using System;
using System.Collections.Generic;
using RobotCleaner.Engine;

namespace RobotCleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number of commands: ");
            int numberOfCommands = int.Parse(Console.ReadLine());

            Console.Write("What is the coordination of robot: ");
            string locationOfRobot = Console.ReadLine();

            List<string> commands = new List<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                Console.Write("Please enter direction and steps: ");
                string commandString = Console.ReadLine();
                commands.Add(commandString);
            }

            Console.WriteLine("Starting cleaning...");
            int countOfCleanedLocation = StartCleaning(locationOfRobot, commands);
            string output = string.Format("=> Cleaned: {0}", countOfCleanedLocation);
            Console.WriteLine(output);
            Console.ReadKey();
        }

        private static int StartCleaning(string locationOfRobot, List<string> commands)
        {
            Robot robot = new Robot(locationOfRobot, commands);
            robot.Start();
            return robot.CountOfUniqueLocations();
        }
    }
}