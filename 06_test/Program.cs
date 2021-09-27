using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_test
{
    class Program
    {
        public static int pairs(int k, List<int> arr)
        {
            var result = 0;
            var dict = new Dictionary<int, int>();
            foreach (var item in arr)
                if (!dict.ContainsKey(item))
                    dict.Add(item, 1);
                else
                    dict[item]++;

            foreach (var item in dict.Keys)
                if (dict.ContainsKey(item+k))
                    result += dict[item];
            return result;


            //var counter = 0;
            //arr.Sort();
            //for (int i = 0; i < arr.Count; i++)
            //    for (int j = 1; j < arr.Count; j++)
            //        if (arr[j]-arr[i]==k)
            //            counter++;
            //return counter;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(pairs(2, new List<int>() { 1, 5, 3, 4, 2 })); //3
            Console.ReadKey();
        }
    }
}
