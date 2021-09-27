using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridSearch
{
    class Program
    {
        public static string gridSearch(List<string> G, List<string> P)
        {
            //foreach (var item in G)
            //{
            //    Console.WriteLine("*"+item.Trim()+"*");
            //}
            //Console.WriteLine();
            //foreach (var item in P)
            //{
            //    Console.WriteLine("*" + item.Trim() + "*");
            //}
            if (G.Count < P.Count)
                return "NO";
            for (int i = 0; i < G.Count - P.Count; i++)

                if (G[i].Contains(P[0].Trim()))
                {
                    if (P.Count==1)
                    {
                        return "YES";
                    }
                    var shift = G[i].IndexOf(P[0].Trim());
                    //Console.WriteLine(i + " " + shift);
                    for (int j = 1; j < P.Count; j++)
                    {
                        if (G[i + j].IndexOf(P[j].Trim()) != shift)
                            return "NO";
                    }
                    return "YES";
                    //if (G[i + 1].IndexOf(P[1].Trim()) == shift && G[i + 2].IndexOf(P[2].Trim()) == shift)
                    //    return "YES";
                }
            return "NO";
        }
        static void Main(string[] args)
        {
            var inputStr = @"34889246430321978567
58957542800420926643
35502505614464308821
14858224623252492823
72509980920257761017
22842014894387119401
01112950562348692493
16417403478999610594
79426411112116726706
65175742483779283052
89078730337964397201
13765228547239925167
26113704444636815161
25993216162800952044
88796416233981756034
14416627212117283516
15248825304941012863
88460496662793369385
59727291023618867708
19755940017808628326";
            var searchStr = @"1641
7942
6517
8907
1376
2691
2599";
            var inputArr = inputStr.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var searchArr = searchStr.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(gridSearch(inputArr.ToList<string>(),searchArr.ToList<string>()));
            Console.ReadKey();


        }
    }
}
