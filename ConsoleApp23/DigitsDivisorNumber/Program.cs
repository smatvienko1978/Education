using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsDivisorNumber
{
    class Program
    {
        public static int findDigits(int n)
        {
            var result = 0;
            var tempString = n.ToString();

            foreach (var digit in tempString)
            {
                if (Int32.Parse(digit.ToString())!=0 && n % Int32.Parse(digit.ToString()) == 0)
                    result++;
            }

            return result;
        }

        static void Main(string[] args)
        {

            Console.WriteLine( findDigits(1012)); //3
            Console.ReadKey();
        }
    }
}
