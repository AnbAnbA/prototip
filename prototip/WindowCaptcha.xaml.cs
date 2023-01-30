using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace prototip
{
    /// <summary>
    /// Логика взаимодействия для WindowCaptcha.xaml
    /// </summary>
    public partial class WindowCaptcha : Window
    {
        int schet;
        public WindowCaptcha(int schet)
        {
            InitializeComponent();
            this.schet = schet;
            string[] capcha=new string[10];
            Random random = new Random();
            for (int i = 0; i<10; i++) 
            {
                capcha[i] = Convert.ToString(random.Next(0, 9)+ (random.Next('A', 'z')));
                string ca = capcha[i];
            }
            //4   5
            ////r    //t
           
            TextBlock te = new TextBlock()
            {

                Text = Convert.ToString(capcha.ToString()),
                Margin = new Thickness(10),
                Padding = new Thickness(10),
                FontSize = 15,
            };
            canvas.Children.Add(te);


            TextBlock tex = new TextBlock()
            {
                
                Text = Convert.ToString(random.Next(1000000, 999999999)),
                Margin = new Thickness(10),
                Padding = new Thickness(10),
                FontSize = 15,
            };
            canvas.Children.Add(tex);
            Line l1 = new Line()
            {
                X1 = random.Next(225),
                Y1 = random.Next(125),
                Stroke = Brushes.Violet,
                StrokeThickness = random.Next(2, 7),
            };
            canvas.Children.Add(l1);
            Line l2 = new Line()
            {
                X1 = random.Next(225),
                Y1 = random.Next(125),
                Stroke = Brushes.SpringGreen,
                StrokeThickness = random.Next(2, 7),
            };
            canvas.Children.Add(l2);
            Line l3 = new Line()
            {
                X1 = random.Next(325,399),
                Y1 = random.Next(10,70),
                Stroke = Brushes.SteelBlue,
                StrokeThickness = random.Next(2, 7),
            };
            canvas.Children.Add(l3);
            Line l4 = new Line()
            {
                X1 = random.Next(355,399),
                Y1 = random.Next(40,100),
                Stroke = Brushes.Tan,
                StrokeThickness = random.Next(2, 7),
            };
            canvas.Children.Add(l4);
            Line l5 = new Line()
            {
                X1 = random.Next(-225,0),
                Y1 = random.Next(125),
                Stroke = Brushes.Tomato,
                Fill= Brushes.Tomato,
                StrokeThickness=random.Next(2,7),
            };
            canvas1.Children.Add(l5);
        }
    }
}
