using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsets
{
    class Program
    {
        static int[] weights = new int[] { 2, 5, 6, 2, 4, 7 };
        public static void Evaluate(bool[] subset)
        {
            var weight = 0;
            for (int i = 0; i < weights.Length; i++)
                if (subset[i])
                    weight += weights[i];
                else
                    weight -= weights[i];

            if (weight == 0)
            {
                foreach (var item in subset)
                    Console.Write(item ? 1 : 0);
                Console.WriteLine();
            }
        }

        public static void MakeSubsets(bool[] subset, int position)
        {
            if (position == subset.Length)
            {
                Evaluate(subset);
                return;
            }
            subset[position] = true;
            MakeSubsets(subset, position + 1);
            subset[position] = false;
            MakeSubsets(subset, position + 1);

        }
        static void Main(string[] args)
        {
            MakeSubsets(new bool[6], 0);
            Console.ReadKey();
        }
    }
}
