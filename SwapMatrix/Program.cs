using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapMatrix
{
    class Program
    {
        public static int flippingMatrix(List<List<int>> matrix)
        {
            int sum = 0;
            int n = matrix[0].Count/2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int num1 = matrix[i][(2 * n) - j - 1];
                    int num2 = matrix[i][j];
                    int num3 = matrix[(2 * n) - i - 1][j];
                    int num4 = matrix[(2 * n) - i - 1][(2 * n) - j - 1];

                    sum += Math.Max(num1, Math.Max(num2, Math.Max(num3, num4)));
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            var input = new List<List<int>>() { 
            new List<int>(){112, 42, 83, 119 },
            new List<int>(){56, 125, 56, 49 },
            new List<int>(){15, 78, 101, 43 },
            new List<int>(){62, 98, 114, 108}};
            
            Console.WriteLine(flippingMatrix(input));//414
            Console.ReadKey();
        }
    }
}
