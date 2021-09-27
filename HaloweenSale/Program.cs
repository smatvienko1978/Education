using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloweenSale
{
    class Program
    {
        public static int howManyGames(int price, int discount, int minimumCost, int sum)
        {
            var result = 0;
            var amount = 0;
            var currentPrice = price;
            while (true)
            {
                amount+=currentPrice;
                if (amount > sum)
                    break;
                currentPrice -= discount;
                if (currentPrice < minimumCost)
                    currentPrice = minimumCost;
                result++;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(howManyGames(20, 3, 6, 80));//6
            Console.ReadKey();

        }
    }
}
