using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavityMap
{
    class Program
    {
        public static List<string> cavityMap(List<string> grid)
        {
            var arr = new List<List<int>>();
            foreach (var item in grid)
            {
                var row = new List<int>();
                foreach (var it in item)
                    row.Add(int.Parse(it.ToString()));
                
                arr.Add(row);
            }
            var dimension = grid.Count;
            var result = new List<string>();
            for (int i = 0; i < dimension; i++)
            {
                var row = "";
                for (int j = 0; j < dimension; j++)
                {
                    if (i == 0 || j == 0 || i == dimension - 1 || j == dimension - 1)
                    {
                        row += (arr[i][j]).ToString();
                        continue;
                    }
                    if (isCavity(arr, i, j))
                        row += "X";
                    else
                        row += (arr[i][j]).ToString();
                }
                result.Add(row);
            }
            return result;
        }

        private static bool isCavity(List<List<int>> arr, int i, int j)
        {
            if (arr[i-1][j] < arr[i][j] && arr[i][j-1] < arr[i][j] && arr[i][j+1] < arr[i][j] && arr[i+1][j] < arr[i][j])
                return true;
            else return false;
        }

        static void Main(string[] args)
        {
            var input = new List<string>() { "1112", "1912", "1892", "1234" };
            var result = cavityMap(input);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
