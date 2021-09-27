using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickingNumbers
{
    class Program
    {
        public static int pickingNumbers(List<int> a)
        {
            var arr = new int[a.Count];
            for (int i = 0; i < a.Count; i++)
                arr[i] = GetLeghtSubArray(a, i);

            return arr.Max(); 
        }

        private static int GetLeghtSubArray(List<int> a, int startPosition)
        {
            int i = 1;
            while (i+startPosition < a.Count)
                if (Math.Abs(a[startPosition] - a[startPosition + i]) <= 1)
                     i++;
                else break;
            return i;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(pickingNumbers(new List<int> { 4, 6, 5, 3, 3, 1 })); // 3
            //Console.WriteLine(pickingNumbers(new List<int> { 1, 2, 2, 3, 1, 2 })); // 5
            Console.ReadKey();
        }
    }
}
