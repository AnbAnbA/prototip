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
    /// Логика взаимодействия для Congratul.xaml
    /// </summary>
    public partial class Congratul : Page
    {
        public static int scet=1;
        public  Congratul()
        {
            InitializeComponent();
            scet++;
        }
    }
}
