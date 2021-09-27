namespace Mazes
{
	public static class DiagonalMazeTask
	{
        private static void MoveRight(Robot robot, int steps)
        {
            for (int i = 0; i < steps; i++)
                robot.MoveTo(Direction.Right);
        }
        
        private static void MoveDown(Robot robot, int steps)
        {
            for (int j = 0; j < steps; j++)
                robot.MoveTo(Direction.Down);
        }
        public static void MoveOut(Robot robot, int width, int height)
        {
            if (width > height)
            {
                int level = height - 2;
                int steps = (width - 2) / (height - 2);
                for (int i = 0; i < level; i++)
                {
                    MoveRight(robot, steps);
                    if (i != level - 1) MoveDown(robot, 1);
                }
            }
            if (width < height-1)
            {
                int level = width - 2;
                int steps = (height - 2) / (width - 2);
                for (int i = 0; i < level; i++)
                {
                    MoveDown(robot, level / steps);
                    if (i != level - 1) MoveRight(robot, 1);
                }
            }
            if (width == height-1)
            {
                for (int i = 0; i < height-2-1; i++)
                {
                    MoveDown(robot, 1);
                    if (i != height -2 - 1 -1) MoveRight(robot, 1);
                }
            }
        }
    }
}