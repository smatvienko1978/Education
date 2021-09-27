using System;

namespace Recognizer
{
    internal static class SobelFilterTask
    { //Транспонирует матрицу
        public static double[,] Transpose(double[,] matr)
        {
            var n = matr.GetUpperBound(0) + 1;
            var m = matr.GetUpperBound(1) + 1;
            var result = new double[m, n];
            for (var i = 0; i < n; i++)
                for (var j = 0; j < m; j++)
                    result[j, i] = matr[i, j];
            return result;
        }
        //Матрица окрестности точки x,y
        public static double[,] GetNeighbourhood(double[,] g, int x, int y, int size)
        {
            var result = new double[size, size];
            result.Initialize();
            var delta = size / 2;
            for (var i = x - delta; i <= x + delta; i++)
                for (var j = y - delta; j <= y + delta; j++)
                    result[i - (x - delta), j - (y - delta)] = g[i, j];
            return result;
        }
        //Произведение матриц.
        public static double MultiplyMatrix(double[,] sxy, double[,] neighbourhood)
        {
            var sum = 0d;
            for (var i = 0; i < neighbourhood.GetUpperBound(0) + 1; i++)
                for (var j = 0; j < neighbourhood.GetUpperBound(0) + 1; j++)
                    sum += sxy[i, j] * neighbourhood[i, j];
            return sum;
        }

        public static double[,] SobelFilter(double[,] g, double[,] sx)
        {
            var width = g.GetLength(0);
            var height = g.GetLength(1);
            var result = new double[width, height];
            var sizeX = sx.GetUpperBound(0) + 1;
            var sizeY = sx.GetUpperBound(1) + 1;
            var deltaX = sizeX / 2;
            var deltaY = sizeY / 2;
            var sy = Transpose(sx);

            for (int x = deltaX; x < width - deltaX; x++)
            {
                for (int y = deltaY; y < height - deltaY; y++)
                {
                    var neighbourhood = GetNeighbourhood(g, x, y, sizeX);
                    var gx = MultiplyMatrix(sx, neighbourhood);
                    var gy = MultiplyMatrix(sy, neighbourhood);
                    result[x, y] = Math.Sqrt(gx * gx + gy * gy);
                }
            }
            return result;
        }
    }
}