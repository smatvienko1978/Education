using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridChallenge
{
    class Program
    {
        public static string gridChallenge(List<string> grid)
        {
            for (int i = 0; i < grid.Count(); ++i)
            {
                char[] s = grid[i].ToCharArray();
                Array.Sort(s);
                grid[i] = new string(s);
            }

            for (int i = 0; i < grid.Count() - 1; i++)
                for (int j = 0; j < grid[i].Length; j++)
                    if (grid[i][j] > grid[i + 1][j])
                        return "NO";
            return "YES";
        }


        static void Main(string[] args)
        {
            var grid = new List<string>() {
                //"ebacd",
                //"fghij",
                //"olmkn",
                //"trpqs",
                //"xywuv"};
               "mpxz",
               "abcd",
               "wlmf" };


            Console.WriteLine(gridChallenge(grid));
            Console.ReadKey();
        }
    }
}
