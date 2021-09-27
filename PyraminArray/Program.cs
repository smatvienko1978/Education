using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Program
    {
            public static int[][] Pyramid(int n)
            {
            if (n == 0) return new int[0][];
            if (n == 1) return new int[][] { new int[] { 1 } };
            
                
                var result = new int[n][];
                for (int i = 1;   i < n; i++)
                {
                    
                var temp = new int[i];

                    for (int j = 0; j < i; j++)
                        temp[j] = 1;
                    result[i] = temp ;
                }
                return result;
            }

        static void Main(string[] args)
        {
        }
    }
}
