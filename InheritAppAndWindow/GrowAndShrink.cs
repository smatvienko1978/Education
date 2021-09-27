using System;
using System.Windows;
using System.Windows.Input;


namespace InheritAppAndWindow
{
    class GrowAndShrink: Window
    {
        [STAThread]
        public static void Main()
        {
            //Application app = new Application();
            //app.Run(new InheritTheWin());
            new Application().Run(new GrowAndShrink());
        }
        public GrowAndShrink()
        {
            Title = "Grow And Shrink";
            Height = 192;
            Width = 192;
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Key==Key.Up)
            {
                Left -= 0.05 * Width;
                Top -= 0.05 * Height;
                Width *= 1.1;
                Height *= 1.1;
            }
            else if (e.Key==Key.Down)
            {
                Left += 0.05 * (Width /= 1.1);
                Top += 0.05 * (Width /= 1.1);
            }
        }
        protected override void OnTextInput(TextCompositionEventArgs e)
        {
            base.OnTextInput(e);
            if (e.Text == "\b" && Title.Length > 0)
                Title = Title.Substring(0, Title.Length - 1);
            else if (e.Text.Length > 0 && !Char.IsControl(e.Text[0]))
                Title += e.Text;
        }
    }
}
