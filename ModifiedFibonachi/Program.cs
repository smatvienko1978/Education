using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ModifiedFibonachi
{
    class Program
    {
        static Dictionary<int, BigInteger> _store = new Dictionary<int, BigInteger>();
        public static BigInteger fibonacciModified(BigInteger t1, BigInteger t2, int n)
        {
            if (!_store.ContainsKey(1))
            {
                _store.Add(1, t1);
                _store.Add(2, t2);
            }

            if (_store.ContainsKey(n))
                return _store[n];
            BigInteger _t1 = fibonacciModified(t1, t2, n - 2);
            BigInteger _t2 = fibonacciModified(t1, t2, n - 1);
            BigInteger result = _t1 + _t2 * _t2;
            _store.Add(n, result);
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(fibonacciModified(0, 1, 5));//5
            Console.WriteLine(fibonacciModified(0, 1, 10));//84266613096281243382112
            Console.ReadKey();
        }
    }
}
