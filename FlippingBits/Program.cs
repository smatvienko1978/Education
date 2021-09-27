using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlippingBits
{
    class Program
    {
        public static long flippingBits(long n)
        {
            BitArray bits = new BitArray(BitConverter.GetBytes(n));
            long result = 0;
            for (int i = 0; i < 32; i++)
                if (!bits[i])
                    result += (long)Math.Pow(2, i);
            return result; 
        }
        static void Main(string[] args)
        {
            
            
            

            //Console.WriteLine(flippingBits(0)); //4294967295
           
            
            
           Console.WriteLine(flippingBits(802743475)); //3492223820
            //Console.WriteLine(flippingBits(35601423)); //4259365872

            Console.ReadKey();
        }
    }
}
