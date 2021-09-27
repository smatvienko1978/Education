using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<int>() { 3, 2, 1 };
            var countSwaps = 0;

            for (int i = 0; i < a.Count; i++)
                for (int j = 0; j < a.Count - 1; j++)
                    if (a[j] > a[j + 1])
                    {
                        var temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;

                        countSwaps++;
                    }
            Console.WriteLine("Array is sorted in "  +countSwaps+ " swaps.");
            Console.WriteLine("First Element: "+a[0]);
            Console.WriteLine("Last Element: "+a.Last());
        }


    }
}
