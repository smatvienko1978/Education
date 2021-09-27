using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    class Program
    {
        static int[,] prices =
        {
            { 0, 2, 4, 7 },
            { 2, 0, 3, 1 },
            { 4, 2, 0, 1 },
            { 3, 5, 2, 0 }
        };

        static void Evaluate (int[] permutations)
        {
            var price = 0;
            for (int i = 0; i < permutations.Length; i++)
                price += prices[permutations[i], permutations[(i + 1) % permutations.Length]];
            foreach (var item in permutations)
                Console.Write(item +" ");
            Console.Write("\t" + price);
            Console.WriteLine();
            return;
        }
        static void MakePermutations(int[] permutations, int position = 0)
        {
            if (position==permutations.Length)
            {
                Evaluate(permutations);
                return;
            }

            for (int i = 0; i < permutations.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < position; j++)
                {
                    if (permutations[j]==i)
                    {
                        found = true;
                        break;
                    }
                }
                if (found) continue;
                permutations[position] = i;
                MakePermutations(permutations, position + 1);
            }
   
        }
        static void Main(string[] args)
        {
            MakePermutations(new int[4]);
            Console.ReadKey();
        }
    }
}
