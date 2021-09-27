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
                if (score < stears[pointer])
                    result.Add(pointer + 2);

                if (score == stears[pointer])
                {
                    result.Add(pointer + 1);
                    pointer--;
                    if (pointer < 0)
                    {
                        pointer = 0;
                    }
                }
                if (score > stears[pointer])
                {
                    while (score >= stears[pointer])
                    {
                        pointer--;
                        if (pointer < 0)
                            break;
                    }
                    result.Add(pointer + 2);
                    if (pointer<0)
                    {
                        pointer = 0;
                    }
                }
            }

            return result;
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
