class Working
{
    private float x = 0;
    private float y = 0;
    private float temp;

    public void RobotTrack(string[] directions)
    {
        
        for (int i = 0; i < directions.Length; i++)
        {
            
            switch (directions[i].ToLower().Split(' ')[0])
            {
                case "left":
                float.TryParse(directions[i].Split(' ')[1], out temp);
                x = x - temp;
                break;

                case "right":
                float.TryParse(directions[i].Split(' ')[1], out temp);
                x = x + temp;
                break;

                case "down":
                float.TryParse(directions[i].Split(' ')[1], out temp);
                y = y - temp;
                break;

                case "up":
                float.TryParse(directions[i].Split(' ')[1], out temp);
                y = y + temp;
                break;

                default:
                System.Console.WriteLine($"Instruction #{i + 1} invalid.");
                break;
            }            
        }
               
        Console.WriteLine($"{x}, {y}");
    }
}