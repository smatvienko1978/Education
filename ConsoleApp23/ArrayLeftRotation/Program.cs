using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLeftRotation
{
    class Program
    {
        public static List<int> rotLeft(List<int> a, int d)
        {
            var result = new int[a.Count];
            for (int i = 0; i < a.Count; i++)
            {
                var j = i - d;
                if (j < 0)
                    j = a.Count + j;
                result[j] = a[i];
            }

            return result.ToList<int>();
        }
        static void Main(string[] args)
        {
        }
    }
}
