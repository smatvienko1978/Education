using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubarrayDivision
{
    class Program
    {
        public static int birthday(List<int> s, int d, int m)
        {
            var result = 0;
            for (int i = 0; i <= s.Count-m; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                    sum += s[i + j];
                if (sum == d)
                    result++;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(birthday (new List<int>() { 2, 2, 1, 3 ,2 }, 4, 2)); //2
            Console.WriteLine(birthday(new List<int>() { 4 }, 4, 1)); //1
            Console.ReadKey();
        }
    }
}
