using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FrequencyArray
{
    class Program
    {
        public static List<int> countingSort(List<int> arr)
        {
            var frequency = new int[100];
            frequency.Initialize();
            foreach (var item in arr)
                frequency[item]++;
            return frequency.ToList<int>();
        }
        static void Main(string[] args)
        {
            var res = countingSort(new List<int>() { 1, 2, 3, 4, 5 });
            Console.ReadKey();
        }
    }
}
