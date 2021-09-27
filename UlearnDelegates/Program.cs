using System;

namespace UlearnDelegates
{
	public class Program
	{
		delegate int TryGet<T>(string str);
		public static void SortStrings(string[] array, Func<string, string, int> comparer)
		{
			for (int i = array.Length - 1; i > 0; i--)
				for (int j = 1; j <= i; j++)
				{
					var element1 = array[j - 1];
					var element2 = array[j];
					if (comparer(element1, element2) > 0)
					{
						var temporary = array[j];
						array[j] = array[j - 1];
						array[j - 1] = temporary;
					}
				}
		}

		static int CompareLength(string x, string y)
		{
			return x.Length.CompareTo(y.Length);
		}

		class AlphCmp
		{
			public bool Descending { get; set; }
			public int Compare(string x, string y)
			{
				return x.CompareTo(y) * (Descending ? -1 : 1);
			}
		}

		static void Main()
		{
			var strs = new[] { "A", "B", "AA" };
			//var lComparer = new SC(CompareLength);
			SortStrings(strs, CompareLength);
			var comparer = new AlphCmp { Descending = true };
			//var sComparer = new SC(comparer.Compare);
			SortStrings(strs, comparer.Compare);
		}
	}
}
