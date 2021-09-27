using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxGreddy
{
    class Program
    {
        public static int maxMin(int k, List<int> arr)
        {
            arr.Sort();
            var min = int.MaxValue;
            for (int i = 0; i <= arr.Count - k; i++)
                if (arr[i + k-1] - arr[i] < min)
                    min = arr[i + k-1] - arr[i];

            return min;
        }

        static void Main(string[] args)
        {
            //var arr = new List<int>() { 4504,1520,5857,4094,4157,3902,822,6643,2422,7288,8245,9948,2822,1784,7802,
            //    3142,9739,5629,5413,7232};
            //Console.WriteLine(maxMin(5, arr)); // 1335
            //Console.WriteLine(maxMin(3, new List<int>() {10, 100, 300, 200, 1000, 20, 30 }));//20
            Console.WriteLine((maxMin(3, new List<int>() { 100,200,300,350,400,401,402}))); //2
            Console.ReadKey();
        }
    }
}
