using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLM
{
    class Program
    {
        public static int viralAdvertising(int n)
        {
            int liked = 2;
            int cumulate = 2;
            for (int i = 1; i < n; i++)
            {

                var recipients = liked * 3;
                liked = (int)Math.Floor((double)(recipients / 2));
                cumulate += liked;
                Console.WriteLine(liked+" "+ cumulate);
            }
            return cumulate;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(viralAdvertising(5));

            Console.ReadKey();
        }
    }
}
