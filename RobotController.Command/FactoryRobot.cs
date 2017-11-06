using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotController.SDK;

namespace RobotController.Command
{
    public static class FactoryRobot
    {
        static IRobot robot = new Robot();
      
        private static List<Action> Actions = new List<Action>();
       
        public static void Move(double distance)
        {
            Action functionToCallLater = () => robot.Move(distance);
            Actions.Add(functionToCallLater);
        }
        public static void Turn(double angle)
        {
            Action functionToCallLater = () => robot.Turn(angle);
            Actions.Add(functionToCallLater);
        }
        public static void Beep()
        {
            Action functionToCallLater = () => robot.Beep();
            Actions.Add(functionToCallLater);
        }

        public static void ExecuteFunctions()
        {
            foreach (var action in Actions)
            {
                action();
            }
        }
    }
}
