using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingLeaderboard
{
    class Program
    {
        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {

            var stears = new List<int>();
            var stear = int.MinValue;

            foreach (var score in ranked)
            {
                if (stear != score)
                {
                    stear = score;
                    stears.Add(score);
                }
            }

            var pointer = stears.Count - 1;
            var result = new List<int>();
            foreach (var score in player)
            {
                pointer = MySearch(stears, score);
                result.Add(pointer);
            }

            return result;
        }
        private static int MySearch(List<int> stears, int score)
        {
            return MyBinarySearch (stears,  score, 0, stears.Count);
        }

        public static int MyBinarySearch(List<int> stears, int score, int left, int right)
        {
            if (left == right-1)
            {
                return left;
            }

            var m = (left + right) / 2;
            if (stears[m] < score)
                return MyBinarySearch(stears, score, m, right );
            return MyBinarySearch(stears, score, left, m);
        }

        static void Main(string[] args)
        {
            //var result = climbingLeaderboard(new List<int>() { 100, 100, 50, 40, 40, 20, 10 },
            //                                        new List<int> { 5, 25, 50, 120 });
            var result = climbingLeaderboard(new List<int>() { 100, 90, 90, 80, 75, 60 },
                                                   new List<int> { 50, 65, 77, 90, 102 });

            foreach (var item in result)
                Console.WriteLine(item);

            //6
            //4
            //2
            //1

            //6
            //5
            //4
            //2
            //1

            Console.ReadKey();
        }
    }
}
