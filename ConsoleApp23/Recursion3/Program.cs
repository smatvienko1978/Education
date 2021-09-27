using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion3
{
    class Program
    {
        static void MakeSubsets(bool[] subset, int position)
        {
            if (position == subset.Length)
            {
                Evaluate(subset);

                Console.WriteLine(" ");
                return;
            }

            subset[position] = false;
            MakeSubsets(subset, position + 1);
            subset[position] = true;
            MakeSubsets(subset, position + 1);
        }

        static int[] weights = new int[] { 2, 5, 6, 2, 4, 7 };
        public static void Evaluate(bool[] subset)
        {
            var delta = 0;
            for (int i = 0; i < subset.Length; i++)
                if (subset[i])
                    delta += weights[i];
                else
                    delta -= weights[i];

            foreach (var item in subset)
                Console.Write(item?1:0);
            if (delta==0)
                    Console.Write("   OK");    
            //Console.WriteLine(" ");
                
        }

        static void Main(string[] args)
        {
            MakeSubsets(new bool[weights.Length], 0);
            Console.ReadKey();
        }
    }
}
