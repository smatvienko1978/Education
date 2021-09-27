using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChockolateFest
{
    class Program
    {
        public static int chocolateFeast(int n, int c, int m)
        {
            var result = n / c;
            var wrappers = result;
            while (wrappers >= m)
            {
                int change = wrappers / m;
                wrappers -= change * m;
                wrappers += change;
                result += change;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(chocolateFeast(10, 2, 5)); //6
            Console.WriteLine(chocolateFeast(12, 4, 4)); //3
            Console.WriteLine(chocolateFeast(6, 2, 2)); //5

            Console.ReadKey();
        }
    }
}
