using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulearn_2
{
    class Program
    {
        static void Main(string[] args)
		{
			var ints = new[] { 1, 2 };
			var strings = new[] { "A", "B" };

			Print(Combine(ints, ints));
			Print(Combine(ints, ints, ints));
			Print(Combine(ints));
			Print(Combine());
			Print(Combine(strings, strings));
			Print(Combine(ints, strings));
			
		}

        private static Array Combine(params Array[] arrays)
        {
			if (arrays.Length == 0)
				return null;
			var firstElementType = arrays[0].GetType().GetElementType();
			var lengthSummary = 0;
			foreach (var item in arrays)
			{
				if (item.GetType().GetElementType() != firstElementType)
					return null;
				lengthSummary += item.Length;
			}
			var result = Array.CreateInstance(firstElementType, lengthSummary);
			var pointer = 0;
			foreach (var item in arrays)
            {
				Array.Copy(item, 0, result, pointer, item.Length);
				pointer += item.Length;
            }
			return result;
		}

        static void Print(Array array)
		{
			if (array == null)
			{
				Console.WriteLine("null");
				return;
			}
			for (int i = 0; i < array.Length; i++)
				Console.Write("{0} ", array.GetValue(i));
			Console.WriteLine();
		}
	}
}
