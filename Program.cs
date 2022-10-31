using System;

namespace TrackTheRobotPt1
{
    class Primary
    {
        public static void Main()
        {
            Console.WriteLine("Simple test");

            Working robot = new Working();
            string[] movement = { "right 10", "up 50", "left 30", "down 10"};
            robot.RobotTrack(movement);
            
        }
    }
}
