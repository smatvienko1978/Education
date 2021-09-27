using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkFor30DaysProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //var t = new int[][]
   //{
   //    new int[] {4,9,2,3,5,7,8,1,6 },
   //    new int[] {4,3,8,9,5,1,2,7,6},
   //    new int[] {2,9,4,7,5,3,6,1,8},
   //    new int[] {2,7,6,9,5,1,4,3,8},
   //    new int[] {8,1,6,3,5,7,4,9,2},
   //    new int[] {8,3,4,1,5,9,6,7,2},
   //    new int[] {6,7,2,1,5,9,8,3,4},
   //    new int[] {6,1,8,7,5,3,2,9,4}
   //};
            string S = Console.ReadLine();
            try
            {
                var result = Int32.Parse(S);
                Console.WriteLine(result);
            }
            catch
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
