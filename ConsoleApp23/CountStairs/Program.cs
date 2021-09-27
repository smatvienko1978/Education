using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountStairs
{
    class Program
    {
  
        public static int stepPerms(int n)
        {
            if (n==0)  return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;
            if (n == 3) return 4;

            var arr = new int[n];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 4;

            for (int i = 3; i < n; i++)
                arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];

            return arr[arr.Length-1];
        }

        static void Main(string[] args)
        {
            Console.WriteLine(stepPerms(5));//13
            Console.ReadKey();
        }
    }
}
