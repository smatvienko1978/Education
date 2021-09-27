using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifilTriplets
{
    class Program
    {
        public static int beautifulTriplets(int d, List<int> arr)
        {
            var dict = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (dict.ContainsKey(item))
                    dict[item]++;
                else
                    dict.Add(item, 1);
            }
            var count = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (dict.ContainsKey(arr[i] + d) && dict.ContainsKey(arr[i] + 2*d))
                    count ++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(beautifulTriplets(3, new List<int>() { 1, 2, 4, 5, 7, 8, 10 })); //3
            Console.WriteLine(beautifulTriplets(3, new List<int>() { 1, 6, 7, 7, 8, 10, 12, 13, 14, 19 })); //2
            Console.ReadKey();
        }
    }
}
