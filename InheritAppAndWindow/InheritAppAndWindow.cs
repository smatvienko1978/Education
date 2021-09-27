using System;
using System.Windows;
using System.Windows.Input;

namespace Book
{
	class InheritAppAndWindow
	{
		[STAThread]
		public static void Main()
		{
			MyApplication app = new MyApplication();
			app.Run();
		}
	}
}
