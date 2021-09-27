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
            //var stears = new List<int>();
            //var stear = int.MinValue;

            //foreach (var score in ranked)
            //{
            //    if (stear!=score)
            //    {
            //        stear = score;
            //        stears.Add(score);
            //    }
            //}

            //stears.Sort();
            //stears.Reverse();
            //var result = new List<int>();

            //foreach (var score in player)
            //{
            //    if (score < stears.Min())
            //        result.Add(stears.Count + 1);
            //    if (score >= stears.Max())
            //        result.Add(1);
            //    if (stears.Contains(score))
            //        result.Add(stears.IndexOf(score)+1);

            //    for (int i = 0; i < stears.Count - 1; i++)
            //    {
            //        if (score<stears[i] && score>stears[i+1])
            //        {
            //            result.Add(i + 2);
            //        }
            //    }
            //}
            //return result;






            var leaderBoard = new List<int>();
            var stear = Int32.MaxValue;
            foreach (var item in ranked)
                if (item < stear)
                {
                    stear = item;
                    leaderBoard.Add(stear);
                }

            var result = new List<int>();
            var pointer = leaderBoard.Count - 1;
            foreach (var item in player)
            {
                if (leaderBoard.Contains(item))
                {
                    pointer = leaderBoard.IndexOf(item);
                    result.Add(pointer + 1);
                    continue;
                }
                if (item >= leaderBoard.Max())
                {
                    result.Add(1);
                    continue;
                }
                if (item < leaderBoard[leaderBoard.Count - 1])
                {
                    result.Add(leaderBoard.Count + 1);
                    continue;
                }

                //for (int i = 0; i < pointer; i++)
                //    if (item < leaderBoard[i] && item > leaderBoard[i + 1])
                //    {
                //        result.Add(i + 1 + 1);
                //        pointer = i + 1;
                //        break;
                //    }

                for (int i = pointer; i >= 0; i--)
                    if (item < leaderBoard[i] && item > leaderBoard[i + 1])
                    {
                        result.Add(i + 1 + 1);
                        pointer = i + 1;
                        break;
                    }
            }
            return result;



            //    var stears = new List<int>();
            //    var stear = int.MinValue;

            //    foreach (var score in ranked)
            //    {
            //        if (stear != score)
            //        {
            //            stear = score;
            //            stears.Add(score);
            //        }
            //    }

            //    stears.Sort();
            //    stears.Reverse();
            //    var pointer = stears.Count-1;
            //    var result = new List<int>();
            //    foreach (var score in player)
            //    {
            //        if (score < stears[pointer])
            //        result.Add(pointer + 2);

            //    if (score == stears[pointer])
            //    {
            //        result.Add(pointer + 1);
            //        pointer--;
            //        if (pointer < 0)
            //        {
            //            pointer = 0;
            //        }
            //    }
            //    if (score > stears[pointer])
            //    {
            //        while (score >= stears[pointer])
            //        {
            //            pointer--;
            //            if (pointer < 0)
            //                break;
            //        }
            //        result.Add(pointer + 2);
            //        pointer = 0;
            //    }
            //}

            //    return result;
        }
        static void Main(string[] args)
        {
            var result = climbingLeaderboard(new List<int>() { 100, 100, 50, 40, 40, 20, 10 },
                                                    new List<int> { 5, 25, 50, 120 });
            foreach (var item in result)
                Console.WriteLine(item);

                //6
                //4
                //2
                //1



                Console.ReadKey();
        }
    }
}
