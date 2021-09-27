using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumToys
{
    class Program
    {
        public static int maximumToys(List<int> prices, int k)
        {
            var countToys = 0;
            var amountToys = 0;
            prices.Sort();
            for (int i = 0; i < prices.Count; i++)
                if (amountToys + prices[i] <= k)
                    amountToys += prices[i];
                else
                { 
                    countToys = i;
                    break;
                }
            return countToys;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(maximumToys(new List<int>() { 1, 12, 5, 111, 200, 1000, 10 }, 50)); //4
        }
    }
}
