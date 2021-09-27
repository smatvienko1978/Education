using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageCount
{
    class Program
    {
        public static int pageCount(int n, int p)
        {
            //return Math.Min(p / 2, p/2, n/2-p/2);
            int stCnt = 0;
            int enCnt = 0;
            if (p > 1 && p != n)
            {
                stCnt = p / 2;
                enCnt = n / 2 - p / 2;
            }
            else return 0;
            return Math.Min(stCnt, enCnt);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(pageCount(5,4));//1
            Console.ReadKey();
        }
    }
}
