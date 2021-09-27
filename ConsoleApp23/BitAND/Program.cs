using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitAND
{
    class Program
    {
        public static int bitwiseAnd(int N, int K)
        {
            var result = new List<int>();
            for (int i = 1; i <N ; i++)
                for (int j = i + 1; j < N; j++)
                    if((i&j)<K)
                        result.Add(i & j);
            
            return result.Max();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(  bitwiseAnd(5, 2));
            Console.ReadKey();
        }
    }
}
