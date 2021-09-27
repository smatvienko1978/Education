using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MansaStonesPermutations
{
    class Program
    {
        public static List<int> stones(int n, int a, int b)
        {  
            var result = new List<int>();
            if (n <= 1) return result;
            var item = 0;
            for (int i = 0; i < n; i++)
            {

                item = a * i + b * (n-1-i);
                if (!result.Contains(item))
                    result.Add(item);
            }
            result.Sort();
            return result;
        }
        public static void PrintResult(int n, int a, int b)
        {
            var result = stones(n, a, b);
            foreach (var item in result)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            PrintResult(3, 1, 2); //2 3 4
            PrintResult(4, 10, 100);// 30 120 210 300

            Console.ReadKey();

        }
    }
}
