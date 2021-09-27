using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Input;

namespace WpfApp2
{
    class ThrowWindowParty//: Application
    {
        [STAThread]
        static void Main(string[] args)
        {

            Window win = new Window();
            win.Title = "Say Helo!";
            win.ShowDialog();

            ////Application app = new Application();
            ////app.Run();
            //ThrowWindowParty app = new ThrowWindowParty();
            ////app.ShutdownMode = ShutdownMode.OnMainWindowClose;
            //app.Run();
        }
    //        protected override void OnStartup(StartupEventArgs args)
    //    {
    //        Window winMain = new Window();
    //        winMain.Title = "Main Window";
    //        winMain.MouseDown += WindowOnMouseDown;
    //        //ShutdownMode = ShutdownMode.OnMainWindowClose;
    //        winMain.Show();

    //        for (int i = 0; i < 2; i++)
    //        {
    //            Window win = new Window();
    //            win.Owner = winMain;
    //            win.ShowInTaskbar = false;
    //            win.Title = "Extra Window No. " + (i + 1);
    //            win.Show();
    //        }
    //    }
    //    void WindowOnMouseDown(object sender, MouseButtonEventArgs args)
    //    {
    //        Window win = new Window();
    //        win.Title = "Modal Dialog Box";
    //        win.ShowDialog();
    //    }
    }
    
}
