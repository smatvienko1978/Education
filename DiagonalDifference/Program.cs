using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            var dimension = arr[0].Count;
            var mainDiagonal = 0;
            var secondDiagonal = 0;
            for (int i = 0; i < dimension; i++)
            {
                mainDiagonal += arr[i][i];
                secondDiagonal += arr[dimension -1 - i][i];
            }
            return Math.Abs(mainDiagonal - secondDiagonal);
        }
        static void Main(string[] args)
        {
            var input = new List<List<int>>()
            {
                new List<int>(){ 11, 2, 4 },
                new List<int>(){  4, 5, 6 },
                new List<int>(){ 10, 8,-12 } };
            Console.WriteLine(diagonalDifference(input)); //15

            Console.ReadKey();
        }
    }
}
