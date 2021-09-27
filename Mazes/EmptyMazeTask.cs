namespace Mazes
{
    public static class EmptyMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            MoveDown(robot, width, height);
            MoveRight(robot, width, height);
        }

        private static void MoveRight(Robot robot, int width, int height)
        {
            for (int i = 0; i < width - 3; i++)
                robot.MoveTo(Direction.Right);
        }

        private static void MoveDown(Robot robot, int width, int height)
        {
            for (int j = 0; j < height - 3; j++)
                robot.MoveTo(Direction.Down);
        }
    }
}