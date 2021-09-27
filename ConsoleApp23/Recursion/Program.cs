using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Make(int n)
        {
            for (int i = n-1; i >= 0; i--)
            {
               // if (n <= 0) return;
                Console.Write(i + " ");
                Make(i);
            }

        }
        static int F(int x)
        {
            if (x % 10 == 0) return 0;
            return 1 + F(x / 10);
        }
        static int G(int x, int y)
        {
            if (y == 0)
                return x;
            else
                return G(y, x % y);
        }
        static void Main(string[] args)
        {
            //Make(2);
            //for (int i = 0; i <15; i++)
            //{
            //    Console.Write(F(i) + " ");
            //}
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                    Console.Write(G(i, j) + " ");
                Console.WriteLine(" ");
            }
            
            Console.ReadKey();
        }
    }
}
