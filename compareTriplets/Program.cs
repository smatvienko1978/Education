using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compareTriplets
{
    class Program
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>() { 0, 0 };
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i]>b[i])
                    result[0]++;
                if (a[i] < b[i])
                    result[1]++;
            }
            return result;
        }
        public static int diagonalDifference(List<List<int>> arr)
        {

            int diag1 = 0, diag2 = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                diag1 += arr[i][i];
                diag2 += arr[i][arr.Count-i-1];
            }
            return Math.Abs(diag1 - diag2);
    }


        static void Main(string[] args)
        {
            //var a = new List<int>() { 1,2,5};
            //var b = new List<int>() { 1, 2, 3 };
            //var result = compareTriplets(a, b);

            //Console.WriteLine(result[0] +"\t" +result[1]);

            var a = new List<List<int>> { new List<int>() { 1, 2, 5 }, new List<int>() { 1, 2, 5 }, new List<int>() { 1, 2, 5 } } ;
            Console.WriteLine(diagonalDifference(a)); ;


            Console.ReadKey();

        }
    }
}
