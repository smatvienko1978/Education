using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LisaBooks
{
    class Program
    {
        //int n: the number of chapters
        //int k: the maximum number of problems per page
        //int arr[n]: the number of problems in each chapter
        public static int workbook(int n, int k, List<int> arr) 
        {
            var result = 0;
            var page = 1;
            for (int i = 0; i < arr.Count; i++)
            {
                var problems = arr[i];
                for (int j = 1; j <= problems; j++)
                {
                    if (j==page)
                        result++;
                    if (j%k==0 || j==problems)
                        page++;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(workbook(5,3, new List<int>() { 4, 2, 6, 1, 10 }));//4
            Console.ReadKey();
        }
    }
}
