using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hourglass
{
    class Program
    {
        static int hourglassSum(List<List<int>> arr)
        {
            int max = Int32.MinValue;
            int total = 0;
            for (int row = 0; row < 4; row++)
            {

                for (int col = 0; col < 4; col++)
                {

                    total = arr[row][col] + arr[row][col + 1] + arr[row][col + 2];
                    total += arr[row + 1][col + 1];
                    total += arr[row + 2][col] + arr[row + 2][col + 1] + arr[row + 2][col + 2];
                    max = total > max ? total : max;
                }
            }
            return max;
        }
            
            static void Main(string[] args)
        {
            var input = new List<List<int>>() {
                new List<int>() {1, 1, 1, 0, 0, 0 },
                new List<int>() {0, 1, 0, 0, 0, 0 },
                new List<int>() {1, 1, 1, 0, 0, 0 },
                new List<int>() {0, 0, 2, 4, 4, 0 },
                new List<int>() {0, 0, 0, 2, 0, 0 },
                new List<int>() {0, 0, 1, 2, 4, 0 } };
            
            Console.WriteLine(hourglassSum(input)); //19
            Console.ReadKey();
        }
    }
}
