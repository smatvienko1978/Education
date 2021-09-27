using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace InheritAppAndWindow
{
    class GradiateTheBrush: Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new GradiateTheBrush());
        }
        public GradiateTheBrush()
        {
            Title = "Gradiate The Brush";
            //LinearGradientBrush brush = new LinearGradientBrush(Colors.White, Colors.Black, 
            //                            new Point(0,0), new Point(1,1));
            //LinearGradientBrush brush = new LinearGradientBrush(Colors.White, Colors.Black,
            //                           new Point(0, 0), new Point(0, 1));
            //LinearGradientBrush brush = new LinearGradientBrush(Colors.Red, Colors.Blue,
            //                          new Point(0, 0), new Point(0.25, 0.25));
            var brush = new RadialGradientBrush(Colors.Red, Colors.Blue);
            brush.SpreadMethod = GradientSpreadMethod.Reflect;
            Background = brush;
            BorderBrush = new LinearGradientBrush(Colors.White, Colors.Black,
                                      new Point(0, 0), new Point(0, 1)); //Brushes.SaddleBrown;
            BorderThickness = new Thickness(50);//Thickness(25,50,75,100);
        }
    }
}
