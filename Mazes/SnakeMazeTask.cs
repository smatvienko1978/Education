namespace Mazes
{
	public static class SnakeMazeTask
	{
        private static void MoveRight(Robot robot, int width, int height)
        {
            for (int i = 0; i < width - 3; i++)
                robot.MoveTo(Direction.Right);
        }
        private static void MoveLeft(Robot robot, int width, int height)
        {
            for (int i = 0; i < width - 3; i++)
                robot.MoveTo(Direction.Left);
        }
        private static void MoveDown(Robot robot, int width, int height)
        {
            for (int j = 0; j < height - 3; j++)
                robot.MoveTo(Direction.Down);
        }


        public static void MoveOut(Robot robot, int width, int height)
		{
            int level = 0;
            level = (height ) / 4;
            for (int i = 0; i < level; i++)
            {
                MoveRight(robot, width, height);
                MoveDown(robot, width, 5);
                MoveLeft(robot, width, height);
                if (i < level-1) MoveDown(robot, width, 5);
            }
        }
	}
}