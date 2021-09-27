using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ZigZag
{
    class Program
    {
        public static void findZigZagSequence(int[] a, int n)
        {
            Array.Sort(a);
            int mid = (n + 1) / 2 - 1; //-1
            int temp = a[mid];
            a[mid] = a[n - 1];
            a[n - 1] = temp;

            int st = mid + 1;
            int ed = n - 2; //-2
            while (st <= ed)
            {
                temp = a[st];
                a[st] = a[ed];
                a[ed] = temp;
                st = st + 1;
                ed = ed - 1; //-1
            }
            for (int i = 0; i < n; i++)
            {
                if (i > 0) Console.WriteLine(" ");
                Console.WriteLine(a[i]);
            }
        }
        static void Main(string[] args)
        {
            findZigZagSequence(new int[] { 2, 3, 5, 1, 4 }, 5);
            Console.ReadKey();
        }
    }
}
