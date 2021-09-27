using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndArray
{
    class Program
    {
        public static string balancedSums(List<int> arr)
        {
            if (arr.Count == 1)
                return "YES";

            if (arr.Count == 2)
                //if (arr[0] == arr[1])
                //    return "YES";
                //else
                    return "NO";
            var sumLeft = 0;
            var sumRight = arr.Sum()-arr[0];
            if (sumRight == 0)
                return "YES";

            for (int i = 0; i < arr.Count-1; i++)
            {
                sumLeft += arr[i];
                sumRight -= arr[i+1];
                if (sumLeft == sumRight)
                    return "YES";
            }
            return "NO";
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(balancedSums(new List<int>() { 1, 2, 3 })); //NO
            Console.WriteLine(balancedSums(new List<int>() { 1, 2, 3, 3 })); //YES

            Console.ReadKey();
        }
    }
}
