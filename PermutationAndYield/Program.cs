using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationAndYield
{
    class Program
    {
        public static int[] weights = new int[] { 2, 5, 6, 2, 4, 7 };
        static void Evaluate(bool[] subset)
        {
            var delta = 0;
            for (int i = 0; i < subset.Length; i++)
                if (subset[i]) delta += weights[i];
                else delta -= weights[i];
            foreach (var e in subset)
                Console.Write(e ? 1 : 0);
            Console.Write(" ");
            if (delta == 0)
                Console.Write("OK");
            Console.WriteLine();
        }
        static IEnumerable<bool[]> MakeSubsets(bool[] subset, int position=0)
        {
            if (position==subset.Length)
            {
                yield return subset;//.ToArray()
                yield break;
            }
            subset[position] = true;
            foreach (var item in MakeSubsets(subset, position + 1))
                yield return item;
            subset[position] = false;
            foreach (var item in MakeSubsets(subset, position + 1))
                yield return item;
        }

        static void Main(string[] args)
        {
            //foreach (var subset in MakeSubsets(new bool[weights.Length]))
            //{
            //    foreach (var item in subset)
            //        Console.Write(item ? 1 : 0);
            //    Console.WriteLine();
            //}

            foreach (var subset in MakeSubsets(new bool[weights.Length]))
                Evaluate(subset);

            //MakeSubsets(new bool[weights.Length], 0);
            Console.ReadKey();
        }
    }
}
