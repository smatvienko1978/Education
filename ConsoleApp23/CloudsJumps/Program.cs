using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudsJumps
{
    class Program
    {
        public static int jumpingOnClouds(List<int> c)
        {
            var position = 0;
            var jumps = -1;

            while (position < c.Count)
            {
                if (c.Count - position > 2 && c[position + 2] != 1)
                {
                    position += 2;
                    jumps++;
                }
                else
                { 
                    position++;
                    jumps++;
                }
            }
            return jumps;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(jumpingOnClouds(new List<int>() { 0, 0, 0 ,0 ,1, 0 })); //3
            Console.WriteLine(jumpingOnClouds(new List<int>() { 0, 0, 1, 0, 0, 1, 0 })); //4

            Console.ReadKey();
        }
    }
}
