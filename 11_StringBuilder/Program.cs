using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_StringBuilder
{
    class Program
    {
		private static string ApplyCommands(string[] commands)
		{
			var builder = new StringBuilder();
			foreach (var line in commands)
			{
				var parce = line.Split(' ');
				if (parce[0] == "push")
				{
					var text = line.Remove(0, 5);
					builder.Append(text);
				}
				if (parce[0] == "pop")
					builder.Remove(builder.Length  - int.Parse(parce[1]), int.Parse(parce[1]));
			}
			return builder.ToString();
		}

		static void Main(string[] args)
        {
            Console.WriteLine(ApplyCommands(new[] {"push Привет! Это снова я! Пока!","pop 5",
					"push Как твои успехи? Плохо?","push qwertyuiop","push 1234567890","pop 26"}));
			Console.ReadKey();
        }
    }
}
