using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion2
{
    class Program
    {
        static void MakeSubsets(bool[] subset, int position)
        {
            if (position==subset.Length)
            {
                foreach (var item in subset)
                    Console.Write(item?1:0);

                Console.WriteLine(" ");
                return;
            }

            subset[position] = false;
            MakeSubsets(subset, position + 1);
            subset[position] = true;
            MakeSubsets(subset, position + 1);
        }
        static void Main(string[] args)
        {
            MakeSubsets(new bool[4],0);
            Console.ReadKey();
        }
    }
}
