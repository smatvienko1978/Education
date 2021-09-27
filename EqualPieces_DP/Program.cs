using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPieces_DP
{
    class Program
    {
        public static int equal(List<int> arr)
        {
            arr.Sort();

            int sum = int.MaxValue;

            for (int _base = 0; _base < 3; _base++)
            {
                int current_sum = 0;
                for (int i = 0; i < arr.Count; i++)
                {
                    int delta = arr[i] - arr[0] + _base;
                    current_sum += (int)delta / 5 + delta % 5 / 2 + delta % 5 % 2 / 1;
                }
                sum = Math.Min(current_sum, sum);
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(equal(new List<int>() { 2, 2, 3, 7 })); //2
            Console.WriteLine(equal(new List<int>() { 10, 7, 12 })); //3

            Console.ReadKey();
        }
    }
}
