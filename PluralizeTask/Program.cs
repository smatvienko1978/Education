using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralize
{
    class Program : ProgramBase
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine(i.ToString() + " " +PluralizeTask(i));
            }
            Console.ReadKey();
        }
    }
}
