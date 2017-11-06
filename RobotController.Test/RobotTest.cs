using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RobotController.Command;

namespace RobotController.Test
{
    [TestFixture]
    public class RobotTest
    {
        [TestCase]
        public void MoveTest()
        {
            double distance = 10.0;
            FactoryRobot.Move(distance);
        }

        [TestCase]
        public void TurnTest()
        {
            double angle = 3.0;
            FactoryRobot.Move(angle);
        }

        [TestCase]
        public void BeepTest()
        {
            FactoryRobot.Beep();
        }
        [TestCase]
        public void ExecuteFunctionsTest()
        {
            FactoryRobot.ExecuteFunctions();
        }
    }
}
