using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChange
{
    class Program
    {
        //public static int getMinCountCoins(int n, List<int> c)
        //{
        //    int minCoins = n;
        //    if (c.Contains(minCoins))
        //    {
        //        return 1;
        //    }
        //    //foreach (var value in c.Where(x => x <= n))
        //    foreach (var value in c)
        //    {
        //        if (value > n)
        //            continue;
        //        int numCoins = 1 + getMinCountCoins(n - value, c);
        //        if (numCoins < minCoins)
        //            minCoins = numCoins;
        //    }
        //    return minCoins;
        //}
        public static int getMinCountCoins(int n, List<int> c, int[] results)
        {
            int minCoins = n;
            if (c.Contains(minCoins))
            {
                results[n] = 1;
                foreach (var item in results)
                    Console.Write(item+ " ");
    
                Console.WriteLine();
                return 1;
            }
            else if (results[n] != 0)
            {
                return results[n];
            }
            //foreach (var value in c.Where(x => x <= n))
            foreach (var value in c)
            {
                if (value > n)
                    continue;
                int numCoins = 1 + getMinCountCoins(n - value, c, results);
                if (numCoins < minCoins)
                {
                    minCoins = numCoins;
                    results[n] = minCoins;
                }
            }
            return minCoins;
        }
        static long count;
        //public static long getCountPermutationCoins(long amount, List<long> coins, long[] results)
        //{
        //    long minCoins = amount;
        //    if (coins.Contains(minCoins))
        //    {
        //        results[amount] = 1;

        //        return 1;
        //    }
        //    else if (results[amount] != 0)
        //    {
        //        return results[amount];
        //    }
        //    //foreach (var value in c.Where(x => x <= n))
        //    foreach (var value in coins)
        //    {
        //        if (value > amount)
        //            continue;

        //        long numCoins = 1 + getCountPermutationCoins(amount - value, coins, results);
        //        count++;

        //    }
        //    foreach (var item in results)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    return count;
        //}



        public static long getWays(long value, List<long> coins, int index, Dictionary<string, long> memo)
        {
            if (value == 0) return 1;
            if (index >= coins.Count) return 0;
            
            string key = value + "-" + index;
            if (memo.ContainsKey(key))
                return memo[key];

            long amountWithCoin = 0;
            long ways = 0;
            while (amountWithCoin <= value)
            {
                long remaining = value - amountWithCoin;
                ways += getWays(remaining, coins, index + 1, memo);
                amountWithCoin += coins[index];
            }
            memo.Add(key, ways);
            return ways;
        }

        public static long getWays(int amount, List<long> coins)
        {
            return getWays((long)amount, coins, 0, new Dictionary<string, long>());
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(getMinCountCoins(10, new List<int>() { 2, 5, 3, 6 }, new int[11] )); //?
            //Console.WriteLine();

            //Console.WriteLine(getWays(10, new List<int>() { 2, 5, 3, 6 }));
            Console.WriteLine(getWays(5, new List<long>() { 1, 2, 5 }));//4

            //Console.WriteLine(getWays(10, new List<int>() { 2, 5, 3, 6 })); //5

            Console.ReadKey();
        }
    }
}
