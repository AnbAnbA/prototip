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
    /// Логика взаимодействия для WindowCode.xaml
    /// </summary>
    public partial class WindowCode : Window
    {
        int codec;
        public WindowCode(int code)
        {
            InitializeComponent();
            codec= code;
        }
    }
}
