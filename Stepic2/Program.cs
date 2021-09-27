using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepic2
{
    class Program
    {
        class A
        {
            public A()
            {

            }
            public static int operator *(A a, string str)
            {
                return a;
            }
            public static implicit operator int(A a)
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            int a = new A() + new A() + new A() * "abc";
        }
    }
}
