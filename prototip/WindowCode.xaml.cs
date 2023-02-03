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
using System.Windows.Threading;

namespace prototip
{
    /// <summary>
    /// Логика взаимодействия для WindowCode.xaml
    /// </summary>
    public partial class WindowCode : Window
    {
        DispatcherTimer timer= new DispatcherTimer();
        int codec;
        int scetc;
        public WindowCode(int code, int schet)
        {
            InitializeComponent();
            codec= code;
            scetc = schet;
            scetc++;
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Tick += new EventHandler(Timer_Trick);
            timer.Start();
        }

        private void tbcode_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbcode.Text.Length == 5) 
            {
                if (Convert.ToInt32(tbcode.Text) == codec)
                {
                    FrameC.frame.Navigate(new Congratul());
                    Close();
                }
                else 
                {
                    MessageBox.Show("Код неверный!");
                    FrameC.frame.Navigate(new Auto(scetc));
                    Close();
                }
            }
        }

        private void Timer_Trick(object sender, EventArgs e) 
        {
            Close();
        }
    }
}
