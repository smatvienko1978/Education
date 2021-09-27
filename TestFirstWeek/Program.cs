using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirstWeek
{
    class Program
    {
        public static int findMedian(List<int> arr)
        {
            arr.Sort();
            var medium = arr.Count / 2;
            if (arr.Count % 2 != 0)
                return arr[medium];
            return (arr[medium] + arr[medium + 1]) / 2;
            
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(findMedian(new List<int>() { 0, 1, 2, 4, 6, 5, 3 })); //3
            Console.WriteLine(findMedian(new List<int>() { 0, 1, 2, 4, 6, 5, 3 })); //3
            Console.ReadKey();
        }
    }
}
