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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace prototip
{
    /// <summary>
    /// Логика взаимодействия для Auto.xaml
    /// </summary>
    public partial class Auto : Page
    {
        DispatcherTimer timer = new DispatcherTimer();
        int schet = 0;
        int ch = 0;
        int ti = 2;
        string login = "admin";
        string password = "admin";
        
        public Auto(int schet)
        {
            InitializeComponent();
            this.schet = schet;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(Timer_Trick);


            //time.Content = timer.Interval.ToString();
            if (schet == 1)
            {
                btnauto.IsEnabled = false;
                btncode.Visibility = Visibility.Visible;
                lb.Visibility = Visibility.Visible;
                time.Visibility = Visibility.Visible;
                timer.Start();
            }
            else if (schet == 2)
            {
                btnauto.IsEnabled = false;
                btncode.Visibility = Visibility.Visible;
                btncode.IsEnabled = false;
                //WindowCaptcha windowCaptcha = new WindowCaptcha(schet);
                //windowCaptcha.ShowDialog();
                
            }
            else
            {
                btnauto.IsEnabled = true;
            }
        }

        private void Timer_Trick(object sender, EventArgs e) 
        {
            if (ti != 0)
            {
                ti--;
                time.Content = ti.ToString();
            }
            else 
            {
                btncode.IsEnabled = true;
            }
        }

        private void btnauto_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int code = random.Next(10000, 90000);
            if (log.Text == login)
            {
                if (pas.Password == password)
                {
                    MessageBox.Show(code.ToString());
                    MessageBoxResult res = MessageBoxResult.OK;
                    switch (res)
                    {
                        case MessageBoxResult.OK:
                            WindowCode windowCode = new WindowCode(code,schet);
                            windowCode.ShowDialog();
                            schet++;
                            if (schet == 1)
                            {
                                btnauto.IsEnabled = false;
                                btncode.Visibility = Visibility.Visible;
                                lb.Visibility = Visibility.Visible;
                                time.Visibility = Visibility.Visible;
                                timer.Start();
                            }
                            else if (schet == 2) 
                            {
                                btnauto.IsEnabled = false;
                                btncode.Visibility = Visibility.Visible;
                                btncode.IsEnabled=false;
                                WindowCaptcha windowCaptcha = new WindowCaptcha(schet, ch);
                                windowCaptcha.ShowDialog();
                                

                            }
                            else
                            {
                                btnauto.IsEnabled = true;
                            }
                            //FrameC.frame.Navigate(new Auto(schet));
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Неверный пароль!");
                }
            }
            else
            {
                MessageBox.Show("Неверный логин!");
            }
        }

        private void btncode_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int code = random.Next(10000, 90000);
            if (log.Text == login)
            {
                if (pas.Password == password)
                {
                    MessageBox.Show(code.ToString());
                    MessageBoxResult res = MessageBoxResult.OK;
                    switch (res)
                    {
                        case MessageBoxResult.OK:
                            WindowCode windowCode = new WindowCode(code, schet);
                            windowCode.ShowDialog();
                            //schet++;
                            if (schet == 1)
                            {
                                btnauto.IsEnabled = false;
                                btncode.Visibility = Visibility.Visible;
                                lb.Visibility = Visibility.Visible;
                                time.Visibility = Visibility.Visible;
                                timer.Start();
                            }
                            else if (schet == 2)
                            {
                                btnauto.IsEnabled = false;
                                btncode.Visibility = Visibility.Visible;
                                btncode.IsEnabled = false;
                                FrameC.frame.Navigate(new Auto(schet));
                                WindowCaptcha windowCaptcha = new WindowCaptcha(schet, ch);
                                windowCaptcha.ShowDialog();
                                break;
                               
                            }
                            else
                            {
                                btnauto.IsEnabled = true;
                            }
                            //FrameC.frame.Navigate(new Auto(schet));
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Неверный пароль!");
                }
            }
            else
            {
                MessageBox.Show("Неверный логин!");
            }
        }
    }
}
