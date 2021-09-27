using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFine
{
    class Program
    {
        private static int GetFine(int[] returned, int[] due)
        {
            if (due[2] > returned[2])
                return 0;
            if (due[2] < returned[2])
                return 10000;
            if (due[1] > returned[1])
                return 0;
            if (due[1] < returned[1])
                return (returned[1] - due[1]) * 500;
            if (due[0]<returned[0])
                return (returned[0] - due[0]) * 15;
            return 0;
        }
        private static int[] ParceInt(string[] arr)
        {
            var result= new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = Int32.Parse(arr[i]);
              // Console.WriteLine(result[i]);
            }
            return result;
        }
        static void Main(string[] args)
        {
            var returned = "31 12 2009".Split(' ');
            var due = "1 1 2010".Split(' ');
            Console.WriteLine(GetFine(ParceInt(returned),ParceInt(due)));

          //  Console.WriteLine(   Char.IsUpper('U'));
        }

        
    }
}
