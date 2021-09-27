using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonDivisibleSubset_Permutations_
{
    class Program
    {
        public static int nonDivisibleSubset(int k, List<int> s)
        {
            int[] arr = new int[k];
            arr.Initialize();
            foreach (var item in s)
                arr[item%k]++;
            int zeroRemainder = arr[0];
            int maxNumberOfDivisibleSet = zeroRemainder > 0 ? 1 : 0;
            for (int i = 1; i <= (k / 2); i++)
                if (i != k - i)
                    maxNumberOfDivisibleSet += Math.Max(arr[i], arr[k - i]);
                else
                    maxNumberOfDivisibleSet++;
            return maxNumberOfDivisibleSet;
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine(nonDivisibleSubset(3, new List<int>() { 1, 7, 2, 4 })); //3
            //Console.WriteLine(nonDivisibleSubset(7, new List<int>() 
            //{ 278, 576, 496, 727, 410, 124, 338, 149, 209, 702, 282, 718, 771, 575, 436 })); //11
            Console.ReadKey();
        }
    }
}
