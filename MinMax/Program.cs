using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        public static void miniMaxSum(List<int> arr)
        {
            long sum=0;
            foreach (var item in arr)
                sum += item;
            long min = sum - arr.Max();
            long max = sum - arr.Min();
            Console.WriteLine("{0} {1}", min, max);
        }

        static void Main(string[] args)
        {
            //miniMaxSum(new List<int>() { 1, 2, 3, 4, 5 });// 10 14
            miniMaxSum(new List<int>() { 256741038, 623958417, 467905213, 714532089, 938071625 }); //2063136757 2744467344
            Console.ReadKey();
        }
    }
}
