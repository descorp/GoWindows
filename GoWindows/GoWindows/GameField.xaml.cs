using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace GoWindows
{
    public partial class GameField : UserControl
    {

        public int n = 0;

        public byte[,] gamefield = new byte[19, 19];

        public GameField()
        {
            // Required to initialize variables

            InitializeComponent();
            for (int i = 0; i < 19; i++)
                Cals.ColumnDefinitions.Add(new ColumnDefinition());

            for (int i = 0; i < 19; i++)
                Cals.RowDefinitions.Add(new RowDefinition());

            //Cals.ShowGridLines = true;
            for (int i = 0; i < 19; i++)
                for (int j = 0; j < 19; j++)
                {
                    Ellipse image = new Ellipse();
                    image.Tap += new EventHandler<GestureEventArgs>(image_Tap);
                    image.Name = "cell_" + i.ToString() + "_" + j.ToString();
                    image.Width = 38;
                    image.Height = 38;
                    SolidColorBrush brush = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                    image.Fill = brush;
                    Grid.SetRow(image, i);
                    Grid.SetColumn(image, j);
                    Cals.Children.Add(image);
                }
        }

        private void image_Tap(object sender, GestureEventArgs e)
        {
            Ellipse temp = (Ellipse)sender;
            string txt = temp.Name;
            int x = int.Parse(txt.Substring(5, txt.LastIndexOf("_") - 5));
            int y = int.Parse(txt.Substring(txt.LastIndexOf("_") + 1, txt.Length - txt.LastIndexOf("_") - 1));
            txtStatus.Text = x.ToString() + " " + y.ToString();

            if (gamefield[x, y] == 0)
            {
                if (n % 2 == 0)
                {
                    SolidColorBrush brush = new SolidColorBrush(Color.FromArgb(255, 48, 48, 48));
                    temp.Fill = brush;
                    gamefield[x, y] = 1;
                }
                else
                {
                    SolidColorBrush brush = new SolidColorBrush(Color.FromArgb(255, 220, 220, 220));
                    temp.Fill = brush;
                    gamefield[x, y] = 2;
                }
                n++;
            }
        }
    }
}