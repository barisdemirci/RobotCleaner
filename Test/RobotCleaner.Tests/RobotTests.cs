using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using RobotCleaner.Engine;
using Xunit;

namespace RobotCleaner.Engine.Tests
{
    public class RobotTests
    {
        [Fact]
        public void Robot_DirectionEast_InRange()
        {
            // arrang
            int expectedCountOfCleanedClocation = 3;
            string locationOfRobot = "10 22";
            List<string> commands = new List<string>()
            {
                "E 2"
            };

            Robot robot = new Robot(locationOfRobot, commands);

            // act
            int result = robot.Start();

            // assert
            result.Should().Be(expectedCountOfCleanedClocation);
        }

        [Fact]
        public void Robot_DirectionWest_InRange()
        {
            // arrang
            int expectedCountOfCleanedClocation = 6;
            string locationOfRobot = "10 22";
            List<string> commands = new List<string>()
            {
                "W 5"
            };

            Robot robot = new Robot(locationOfRobot, commands);

            // act
            int result = robot.Start();

            // assert
            result.Should().Be(expectedCountOfCleanedClocation);
        }

        [Fact]
        public void Robot_DirectionNorth_InRange()
        {
            // arrang
            int expectedCountOfCleanedClocation = 8;
            string locationOfRobot = "10 22";
            List<string> commands = new List<string>()
            {
                "N 7"
            };

            Robot robot = new Robot(locationOfRobot, commands);

            // act
            int result = robot.Start();

            // assert
            result.Should().Be(expectedCountOfCleanedClocation);
        }

        [Fact]
        public void Robot_DirectionSouth_InRange()
        {
            // arrang
            int expectedCountOfCleanedClocation = 11;
            string locationOfRobot = "10 22";
            List<string> commands = new List<string>()
            {
                "S 10"
            };

            Robot robot = new Robot(locationOfRobot, commands);

            // act
            int result = robot.Start();

            // assert
            result.Should().Be(expectedCountOfCleanedClocation);
        }

        [Fact]
        public void Robot_DirectionSouth_OutOfRange()
        {
            // arrang
            int expectedCountOfCleanedClocation = 1;
            string locationOfRobot = "10 -99999";
            List<string> commands = new List<string>()
            {
                "S 10"
            };

            Robot robot = new Robot(locationOfRobot, commands);

            // act
            int result = robot.Start();

            // assert
            result.Should().Be(expectedCountOfCleanedClocation);
        }

        [Fact]
        public void Robot_DirectionNorth_OutOfRange()
        {
            // arrang
            int expectedCountOfCleanedClocation = 1;
            string locationOfRobot = "0 99999";
            List<string> commands = new List<string>()
            {
                "N 10"
            };

            Robot robot = new Robot(locationOfRobot, commands);

            // act
            int result = robot.Start();

            // assert
            result.Should().Be(expectedCountOfCleanedClocation);
        }

        [Fact]
        public void Robot_DirectionEast_OutOfRange()
        {
            // arrang
            int expectedCountOfCleanedClocation = 1;
            string locationOfRobot = "99999 10";
            List<string> commands = new List<string>()
            {
                "E 10"
            };

            Robot robot = new Robot(locationOfRobot, commands);

            // act
            int result = robot.Start();

            // assert
            result.Should().Be(expectedCountOfCleanedClocation);
        }

        [Fact]
        public void Robot_DirectionWest_OutOfRange()
        {
            // arrang
            int expectedCountOfCleanedClocation = 1;
            string locationOfRobot = "-99999 10";
            List<string> commands = new List<string>()
            {
                "W 10"
            };

            Robot robot = new Robot(locationOfRobot, commands);

            // act
            int result = robot.Start();

            // assert
            result.Should().Be(expectedCountOfCleanedClocation);
        }

        [Fact]
        public void Robot_Goes_SameLine()
        {
            // arrang
            int expectedCountOfCleanedClocation = 11;
            string locationOfRobot = "10 22";
            List<string> commands = new List<string>()
            {
                "E 5",
                "W 5",
                "E 5",
                "N 5",
                "S 5"
            };

            Robot robot = new Robot(locationOfRobot, commands);

            // act
            int result = robot.Start();

            // assert
            result.Should().Be(expectedCountOfCleanedClocation);
        }

        [Fact]
        public void Robot_Goes_Rectangle()
        {
            // arrang
            int expectedCountOfCleanedClocation = 22;
            string locationOfRobot = "10 22";
            List<string> commands = new List<string>()
            {
                "N 5",
                "E 6",
                "S 5",
                "W 6"
            };

            Robot robot = new Robot(locationOfRobot, commands);

            // act
            int result = robot.Start();

            // assert
            result.Should().Be(expectedCountOfCleanedClocation);
        }
    }
}