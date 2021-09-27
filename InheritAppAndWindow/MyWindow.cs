using System;
using System.Windows;
using System.Windows.Input;

namespace Book
{
	public class MyWindow : Window
	{
		public MyWindow()
		{
			this.Title = "Inherit App & Window";
		}
		protected override void OnMouseDown(MouseButtonEventArgs args)
		{
			base.OnMouseDown(args);
			string strMessage =
			string.Format("Window clicked with {0} buton at point ({1})",
				args.ChangedButton, args.GetPosition(this));
			MessageBox.Show(strMessage, Title);
		}
	}
}