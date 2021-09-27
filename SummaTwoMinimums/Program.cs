using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaTwoMinimums
{
    class Program
    {
        public static long FindNextSquare(long num)
        {
            if (Math.Sqrt(num) / Math.Round(Math.Sqrt(num)) != 1)
                return -1;
            return (long)((Math.Sqrt(num) + 1) * (Math.Sqrt(num) + 1));

        }
        static void Main(string[] args)
        {
            
            Console.WriteLine(FindNextSquare(121));
            Console.WriteLine(FindNextSquare(625));
            Console.WriteLine(FindNextSquare(114));

            Console.ReadKey();
        }
    }
}
