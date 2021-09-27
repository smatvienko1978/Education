using System.Windows;
using System.Windows.Controls;

namespace XamlApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button myButton = new Button();
            myButton.Width = 200;
            myButton.Height = 50;
            myButton.Content = "Кнопка";
            myButton.Click += button1_Click;
            TextBox myTextbox = new TextBox();
            myTextbox.Width = 100;
            myTextbox.Height = 30;

            layoutGrid.Children.Add(myButton);
            layoutGrid.Children.Add(myTextbox);

        }



        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string text = "";
            if (text != "")
            {
                MessageBox.Show(text);
            }
        }
    }
}
