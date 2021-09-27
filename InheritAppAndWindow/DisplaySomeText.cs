using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace InheritAppAndWindow
{
    class DisplaySomeText : Window
    {
        [STAThread]
        public static void Main()
        {
            var app = new Application();
            app.Run(new DisplaySomeText());     
        }
        public DisplaySomeText()
        {
            //var brush = new RadialGradientBrush(Colors.Red, Colors.Blue);
            //brush.SpreadMethod = GradientSpreadMethod.Reflect;
            //Background = brush;
            //BorderBrush = new LinearGradientBrush(Colors.White, Colors.Black,
            //                          new Point(0, 0), new Point(0, 1)); //Brushes.SaddleBrown;
            //BorderThickness = new Thickness(50);//Thickness(25,50,75,100);
            FontFamily = new FontFamily("Comic Sans MS");
            FontSize = 48;
            FontStyle = FontStyles.Oblique;

            Brush brush = new LinearGradientBrush(Colors.White, Colors.Black, new Point(0, 0), new Point(1, 1));
            Background = brush;
            Foreground = brush;
            SizeToContent = SizeToContent.WidthAndHeight;
            ResizeMode = ResizeMode.NoResize;
            
            Title = "Display Some Text";
            Content = "Content can be simple text!";
        }
    }
}
