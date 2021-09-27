using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    class Program
    {
        static void MakePermutations(int[] permutation, int position)
        {
            if (position==permutation.Length)
            {
                foreach (var item in permutation)
                    Console.Write(item + " ");
                Console.WriteLine();
                return;
            }

            for (int i = 0; i < permutation.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < position; j++)

                    if (permutation[j] == i)
                    {
                        found = true;
                        break;
                    }
                    if (found) continue;
                    permutation[position] = i;
                    MakePermutations(permutation, position + 1);

            }
        }
        static void Main(string[] args)
        {
            MakePermutations(new int[5], 0);
            Console.ReadKey();
        }
    }
}
