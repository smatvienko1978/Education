using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterGame
{
    class Program
    {
        public static string counterGame(long n)
        {
            int counter = 0;
            while (n != 1)
            {
                counter++;
                String binaryString = ConvertToBitString(n);
                n = (long)(binaryString.LastIndexOf("1") == 0 ?
                    n / 2 : n - Math.Pow(2, binaryString.Length - 1));
            }
            return counter % 2 == 0 ? "Richard" : "Louise";
        }
        public static string ConvertToBitString(long number)
        {
            if (number == 1)
                return "1";
            else
                return ConvertToBitString(number / 2) + (number % 2);
        }

        static void Main()
        {
            Console.WriteLine(counterGame(6)); // Richard
            Console.ReadKey();
        }
    }
}
