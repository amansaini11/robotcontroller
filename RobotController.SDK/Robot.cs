using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotController.SDK
{
    public class Robot : IRobot
    {
        public void Move(double distance)
        {
            throw new ArgumentNullException();
        }
        public void Turn(double angle)
        {
            throw new ArgumentNullException();
        }
        public void Beep()
        {
            throw new ArgumentNullException();
        }
    }
}
