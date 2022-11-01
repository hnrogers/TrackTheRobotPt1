namespace TrackTheRobotPt1
{
    class Primary
    {
        public static void Main()
        {
            
            Working robot = new Working();
            string[] movement = { "right 10", "up 50", "left 30", "down 10", "poopoo 6"};
            robot.RobotTrack(movement);
            
        }
    }
}
