using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuzzFizz
{
    class Program
    {
        public static void fizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
                Print(i);
        }

        private static void Print(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else
            if (n % 3 == 0)
                Console.WriteLine("Fizz");
            else
            if (n % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(n);
        }

        static void Main(string[] args)
        {
            fizzBuzz(15);
            //fizzBuzz(2);
            //fizzBuzz(3);
            //fizzBuzz(5);
            //fizzBuzz(15);

            Console.ReadKey();
        }
    }
}
