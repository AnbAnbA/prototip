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

namespace prototip
{
    /// <summary>
    /// Логика взаимодействия для Auto.xaml
    /// </summary>
    public partial class Auto : Page
    {
        string login = "admin";
        string password = "admin";
        public Auto()
        {
            InitializeComponent();
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
                            WindowCode windowCode = new WindowCode(code);
                            windowCode.ShowDialog();
                            FrameC.frame.Navigate(new Auto());
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
