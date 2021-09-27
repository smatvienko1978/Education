using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cacl
{
    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            var divisors = new List<int>();
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                }
            }
            return divisors.Sum() ;
        }
    }

}
