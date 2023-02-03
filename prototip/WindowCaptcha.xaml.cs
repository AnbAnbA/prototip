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
        int ch = 0;
        int schet;
        string ca = "";
        public WindowCaptcha(int schet, int ch)
        {
            InitializeComponent();
            this.schet = schet;
            this.ch = ch;
            string[] capcha=new string[10];
            string[] capc = new string[10];
            Random random = new Random();
           
            //string symb = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //char[] arr_en = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            
            for (int i = 0; ca.Length < 8; i++)
            {
                if (random.Next(1, 3) == 1)
                {
                    capcha[i] = Convert.ToString(random.Next(0, 9)) + (char)(random.Next('A', 'Z'));
                    ca = ca + capcha[i];
                }
                else 
                {
                    capcha[i] = Convert.ToString(random.Next(0, 9)) + (char)(random.Next('a', 'z'));
                    ca = ca + capcha[i];
                }
                capc[i]=capcha[i];
            }
            //4   5
            ////r    //t
           
            TextBlock te = new TextBlock()
            {

                Text = Convert.ToString(ca.ToString()),
                Margin = new Thickness(20),
                Padding = new Thickness(40),
                FontSize = 15,
            };
            canvas.Children.Add(te);


            //TextBlock tex = new TextBlock()
            //{
                
            //    Text = Convert.ToString(random.Next(1000000, 999999999)),
            //    Margin = new Thickness(10),
            //    Padding = new Thickness(10),
            //    FontSize = 15,
            //};
            //canvas.Children.Add(tex);
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
                X1 = random.Next(-325,0),
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
        //int cl=0;
        private void captchacode_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (cl >0)
            //{
                //if (captchacode.Text == ca)
                //{
                //    FrameC.frame.Navigate(new Congratul());
                //}
                //else
                //{
                //    MessageBox.Show("Код неверный!");
                //    FrameC.frame.Navigate(new Auto(schet));
                //    Close();
                //}
            //}
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            //cl++;
            if (captchacode.Text == ca)
            {
                FrameC.frame.Navigate(new Congratul());
                Close();
            }
            else
            {
                if (ch == 0) 
                {
                    ch++;
                    MessageBox.Show("Код неверный!");
                    MessageBox.Show("Повторите попытку!");
                    Close();
                    WindowCaptcha windowCaptcha = new WindowCaptcha(schet, ch);
                    windowCaptcha.ShowDialog();
                    
                }
                else if (ch == 1)
                {
                    MessageBox.Show("Код неверный!");
                    MessageBox.Show("Не удалось произвести вход!");
                    FrameC.frame.Navigate(new Auto(schet));
                    Close();
                }
                //MessageBox.Show("Код неверный!");
                //FrameC.frame.Navigate(new Auto(schet));
                Close();
            }
           
        }
    }
}
