using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDistance
{
    class Program
    {
        public static int minimumDistances(List<int> a)
        {
            var result = Int32.MaxValue;
            for (int i = 0; i < a.Count-1; i++)
                for (int j = i+1; j < a.Count; j++)
                    if (a[i] == a[j] && Math.Abs(i - j) < result)
                        result = Math.Abs(i - j);
            return result == Int32.MaxValue ? -1 : result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(minimumDistances(new List<int>() { 7, 1, 3, 4, 1, 7 }));//3
            Console.ReadKey();
        }
    }
}
