using System;
using System.Collections.Generic;

namespace Recognizer
{
	public static class ThresholdFilterTask
	{
		public static double[,] ThresholdFilter(double[,] original, double whitePixelsFraction)
		{
			var result = new double[original.GetLength(0), original.GetLength(1)];
            result.Initialize();
            
            var trashholdStack = GetTrasholdStack(original);

            int whitePixelsMinCount = (int)(original.Length * whitePixelsFraction);

            if (whitePixelsMinCount == 0)
                return result;
          
            var whitePixelsCount = 0;
            double trashold = trashholdStack.Pop();
            while (trashholdStack.Count>0)
            {             
                whitePixelsCount = CountWhitePixels(original, trashold);
                if (whitePixelsMinCount <= whitePixelsCount)
                    break;
                trashold = trashholdStack.Pop();
            }
            result = GetResult(original, trashold);

            return result;
        }

        private static Stack<double> GetTrasholdStack(double[,] original)
        {
            var result = new Stack<double>();
            var temp = new List<double>();
            foreach (var item in original)
                temp.Add(item);
            temp.Sort();
            double trashhold = 0;
            foreach (var item in temp)
            {
                if (item>trashhold)
                {
                    trashhold = item;
                    result.Push(item);
                }
            }
           
            return result;
        }

        private static double[,] GetResult(double[,] original, double treshold)
        {
            var x = original.GetLength(0);
            var y = original.GetLength(1);
            var result = new double[x, y];
            for (int i = 0; i < x; i++)
                  for (int j = 0; j < y; j++)
                      if (original[i, j] >= treshold)
                          result[i, j] = 1;
                      else
                          result[i, j] = 0;
            return result;
        }

        private static int CountWhitePixels(double[,] original, double treshold)
        {
            int result =0;
            foreach (var item in original)
                if (item>=treshold)
                    result++;
            return result;
        }
    }
}