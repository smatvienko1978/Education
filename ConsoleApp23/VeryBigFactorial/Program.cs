using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace VeryBigFactorial
{
    class Program
    {
        //public static void extraLongFactorials(int n)
        //{
        //    BigInteger result = new BigInteger(1);
        //    for (int i = 1; i <= n; i++)
        //        result = result * i;
        //    Console.WriteLine(result);
        //}
        //static BigInteger result;
        public static BigInteger GetFactorial(int n)
        {
            if (n == 1) return 1;

            return n * GetFactorial(n - 1);
        }
        public static void extraLongFactorials(int n)
        {
            Console.WriteLine(GetFactorial(n));
        }
        static void Main(string[] args)
                                      
        {
            extraLongFactorials(25); //15511210043330985984000000
            extraLongFactorials(45);
            Console.ReadKey();
        }
    }
}
