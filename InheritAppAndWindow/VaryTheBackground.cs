﻿using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace InheritAppAndWindow
{
    class VaryTheBackground : Window
    {
        SolidColorBrush brush = new SolidColorBrush(Colors.Black);

        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new VaryTheBackground());
        }
        public VaryTheBackground()
        {
            Title = "Vary The Background";
            Width = 384;
            Height = 384;
            Background = brush;
        }
        protected override void OnMouseDown(MouseButtonEventArgs args)
        {
            double width = ActualWidth - 2 * SystemParameters.ResizeFrameVerticalBorderWidth;
            double height = ActualHeight - 2 * SystemParameters.ResizeFrameHorizontalBorderHeight 
                -SystemParameters.CaptionHeight;
            Point ptMouse = args.GetPosition(this);
            Point ptCenter = new Point(width / 2, height / 2);
            Vector vectMouse = ptMouse - ptCenter;
            double angle = Math.Atan2(vectMouse.Y, vectMouse.X);
            Vector vectEllipse = new Vector(width/2*Math.Cos(angle), height/2*Math.Cos(angle));
            byte byLevel = (byte)(255 * (1 - Math.Min(1, vectMouse.Length / vectEllipse.Length)));
            Color clr = brush.Color;
            clr.R = clr.G = clr.B = byLevel;
            brush.Color = clr;




            //base.OnMouseDown(args);
        }
    }
}
