using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApp22
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine(MyLib.timeConversion("07:05:45PM")); ;
            Console.ReadKey();
        }
    }
}
