using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamPailor
{
    class Program
    {
        public static List<int> icecreamParlor(int m, List<int> arr)
        {
            //var rslt = new List<int>();
            //for (int i = 0; i < arr.Count-1; i++)
            //{
            //    var item1 = arr[i];
            //    if (arr.Contains(m-item1))
            //    {
            //        rslt.Add(arr.IndexOf(item1) + 1);
            //        rslt.Add(arr.LastIndexOf(m - item1) + 1);
            //        break;
            //    }
            //}
            //if (rslt[0]>rslt[1])
            //{
            //    var temp = rslt[0];
            //    rslt[0] = rslt[1];
            //    rslt[1] = temp;
            //}
            //return rslt;
            var res = new List<int>();
            for (int i = 0; i < arr.Count - 1; i++)
                for (int j = i + 1; j < arr.Count; j++)
                    if (arr[i] + arr[j] == m)
                    {
                        res.Add(i + 1);
                        res.Add(j + 1);
                    }
            return res;
        }
        static void Main(string[] args)
        {
            //var rslt = icecreamParlor(4, new List<int>() { 1, 4, 5, 3, 2 });//1 4
            var rslt = icecreamParlor(4, new List<int>() { 2, 2, 4, 3 });//1 2
            foreach (var item in rslt)
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
