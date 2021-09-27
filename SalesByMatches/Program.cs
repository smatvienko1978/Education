using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesByMatches
{
    class Program
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            var dict = new Dictionary<int, int>();
            var result = 0;
            foreach (var item in ar)
            {
                if (!dict.ContainsKey(item))
                    dict.Add(item, 1);
                else 
                {
                    dict.Remove(item);
                    result++;
                }
            }
            return result;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(sockMerchant(9, new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 }));//3
            Console.ReadKey();
        }
    }
}
