using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    class Program
    {
        // Soution needs implement Stack or/and Query
        public static string isBalanced(string s)
        {
            if (s.Length % 2 != 0) return "NO";     
            var stack = new Stack<char>();
            foreach (var item in s)
            {
                if (item == '[' || item == '{' || item == '(')
                    stack.Push(item);
                if (item == ']' || item == '}' || item == ')')
                {
                    if (stack.Count == 0)
                        return "NO";
                    var symbol = stack.Pop();
                    if (item == ']' && symbol == '[') continue;
                    if (item == '}' && symbol == '{') continue;
                    if (item == ')' && symbol == '(') continue;
                    return "NO";
                } 
            }
            if (stack.Count != 0)
                return "NO";
            return "YES";
        }

        static void Main(string[] args)
        {
            //Console.WriteLine( isBalanced("{{[[(())]]}}")); //YES
            Console.WriteLine(isBalanced("}([[{)[]))]{){}[")); 

            Console.ReadKey();
        }
    }
}
