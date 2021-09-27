using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwiceOlder
{
    class Program
    {
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            var ratio = dadYears / 2;
            if (sonYears == 0)
                return dadYears;
            if (ratio == sonYears)
                return 0;
            if (ratio > sonYears)
                for (int i = 0; i < 200; i++)
                    if (dadYears + i == (sonYears + i) * 2)
                        return i;

            for (int i = 0; i < sonYears; i++)
                if (dadYears - i == (sonYears - i) * 2)
                    return i;
            return dadYears;
            var eee = new List<int>();
            eee.Max();
        }


        static void Main(string[] args)
        {
            Console.WriteLine(TwiceAsOld(30, 7));
            Console.ReadKey();

        }
    }
    
}
