using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaLuckGreddy
{
    class Program
    {
        public static int luckBalance(int k, List<List<int>> contests)
        {
            var luck = 0;
            var temp = new List<int>();
            foreach (var contest in contests)
            {
                if (contest[1]==0)
                {
                    luck += contest[0];
                    continue;
                }
                temp.Add(contest[0]);
            }
            if (temp.Count<=k)
            {
                foreach (var item in temp)
                    luck += item;
                return luck;
            }
            temp.Sort();
            temp.Reverse();
            for (int i = 0; i < k; i++)
                luck += temp[i];
            for (int i = k; i < temp.Count; i++)
                luck -= temp[i];
            return luck;
        }
        static void Main(string[] args)
        {
            var input = new List<List<int>>() {
                new List<int>() {5, 1},
                new List<int>() {2, 1},
                new List<int>() {1, 1},
                new List<int>() {8, 1},
                new List<int>() {10, 0},
                new List<int>() {5, 0}};
            Console.WriteLine(luckBalance(3, input)); //29
        }
    }
}
