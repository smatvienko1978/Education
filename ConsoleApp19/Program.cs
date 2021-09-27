using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    
    class Program
    {
        static int Calculate(int n)
        {
            string result = "";
            string tmp = n.ToString();
            foreach (var item in tmp)
            {
                var temp_str  =item.ToString();
                var  temp_int = int.Parse(temp_str);
                temp_int = temp_int * temp_int;
                result += temp_int.ToString();
                Console.WriteLine(item + " - " + result);
            }

            return int.Parse(result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(int.Parse(Console.ReadLine())));

            Console.ReadKey();
        }

    }
}
