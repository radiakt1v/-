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

namespace Учебнаяпрактика
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void zakazbut_Click(object sender, RoutedEventArgs e)
        {
            Window2 oknozakaz = new Window2();
            oknozakaz.Show();
            this.Close();
        }

        private void klientbut_Click(object sender, RoutedEventArgs e)
        {
            Window3 oknoklient = new Window3();
            oknoklient.Show();
            this.Close();
        }

        private void helpbutbut_Click(object sender, RoutedEventArgs e)
        {
            Window4 oknohelp = new Window4();
            oknohelp.Show();
            this.Close();
        }

        private void hpbut_Click(object sender, RoutedEventArgs e)
        {
            Window5 oknohp = new Window5();
            oknohp.Show();
            this.Close();
        }

        private void exitbut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow f = new MainWindow();
            f.Show();
            this.Close();
        }

        private void vixod_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
