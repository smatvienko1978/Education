using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountStairsRecursion
{
    class Program
    {
    //    static List<int> arr= new List<int>();
        public static int stepPerms(int n)
          {
            if (n == 1) return 1;
            if (n == 2) return 2;
            if (n == 3) return 4;


            return stepPerms(n-1)+stepPerms(n-2)+stepPerms(n-3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(stepPerms(5)); //13
            Console.ReadKey();
        }
    }
}
