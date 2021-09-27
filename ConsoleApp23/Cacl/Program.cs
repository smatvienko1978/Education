using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        class Calculator
        {
         public int power (int n, int p)
            {
                if (n < 0 || p < 0)
                    throw new Exception("n and p should be non-negative");
                return (int)Math.Pow(n,p);
            }
        }
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();

            int n = 2;
            int p = 2;
            try
            {
                int ans = myCalculator.power(n, p);
                Console.WriteLine(ans);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
