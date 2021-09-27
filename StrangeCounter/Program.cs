using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeCounter
{
    class Program
    {
        public static long strangeCounter(long t)
        {
            var shoulder = 3;
            while (t > shoulder)
            {
                t -= shoulder;
                shoulder *= 2;
            }
            return shoulder - t + 1;


            //long counter = 3;
            //int multiplier = 3;
            //for (long i = 1; i <= t; i++)
            //{
            //    counter--;
            //    if (counter==0)
            //    {
            //        multiplier *= 2;
            //        counter = multiplier;
            //    }
            //}
            //return counter+1;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(strangeCounter(4));//6
            Console.ReadKey();
        }
    }
}
