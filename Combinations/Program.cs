using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinations
{
    class Program
    {
        static void MakeCombinations(bool[] combinations, int elements, int position=0)
        {
            if (elements==0)
            {
                for (int i = position; i < combinations.Length; i++)
                    combinations[i] = false;

                foreach (var item in combinations)
                    Console.Write((item?1:0)+ " ");
                Console.WriteLine();
                return;
            }
            if (position == combinations.Length && elements > 0)
                return;
            combinations[position] = true;
            MakeCombinations(combinations, elements - 1, position + 1);
            combinations[position] = false;
            MakeCombinations(combinations, elements, position + 1);
        }
        static void Main(string[] args)
        {
            MakeCombinations(new bool[5], 3);
            Console.ReadKey();
        }
    }
}
