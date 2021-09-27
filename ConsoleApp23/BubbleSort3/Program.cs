using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort3
{
    class Program
    {
        static int minimumSwaps(int[] arr)
        {
            int i = 0;
            int count = 0;
            int temp;
            int n = arr.Length;
            while (i < n)
            {
                if (arr[i] !=i + 1)
                {
                    temp = arr[i];
                    arr[i] = arr[temp - 1];
                    arr[temp - 1] = temp;
                    count++;
                }
                else
                    i++;
            }
            return count;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(minimumSwaps(new int[] { 1, 3, 5, 2, 4, 6, 7 })); //3
        }
    }
}
