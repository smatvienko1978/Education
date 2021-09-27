using System;
using System.Collections.Generic;
using System.Drawing;

namespace RoutePlanning
{
	public static class PathFinderTask
	{
		public static int[] FindBestCheckpointsOrder(Point[] checkpoints)
		{

			var numberOfCheckpoints = checkpoints.Length;
			var shortestPath = new int[numberOfCheckpoints];
			var path = new int[numberOfCheckpoints];
			var shortestDistance = double.PositiveInfinity;

			MakeTrivialPermutation(checkpoints, shortestPath, path, 1, shortestDistance);

			return shortestPath;
		}

		private static double MakeTrivialPermutation(Point[] checkpoints, int[] shortestPath,
            int[] path, int position, double shortestDistance)
        {

            for (int i = 0; i < checkpoints.Length; i++)
            {
                if (position==path.Length && checkpoints.GetPathLength(path)<shortestDistance)
                {
					shortestDistance = checkpoints.GetPathLength(path);
					Array.Copy(path, shortestPath, checkpoints.Length);
					return shortestDistance;
				}

                if (Array.IndexOf(path,i,0,position)==-1)
                {
					path[position] = i;
					shortestDistance = MakeTrivialPermutation(checkpoints, shortestPath, path, position + 1, shortestDistance);
                }
            }
			return shortestDistance;
        }
    }
}