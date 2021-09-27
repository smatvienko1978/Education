using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LonelyInteger
{
    class Program
    {
        public static int lonelyinteger(List<int> a)
        {
            var dict = new Dictionary<int, int>();
            foreach (var item in a)
                if (!dict.ContainsKey(item))
                    dict.Add(item, 1);
                else
                    dict.Remove(item);
            var result = 0;
            foreach (var item in dict.Keys)
                result = item;
            return result;
        }
        static void Main(string[] args)
        {
        }
    }
}
