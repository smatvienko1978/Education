using System;
using System.Windows;
//using MathNet.Numerics;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;


namespace WPF_1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            Window win = new Window();
            win.Title = "Say Helo!";
            win.Show();

            Application app = new Application();
            app.Run();
        }
    }
}
