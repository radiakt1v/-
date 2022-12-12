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

namespace Учебнаяпрактика
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        string logArg;
        string parlArg;
        public MainWindow()
        {
            InitializeComponent();

            
        }
        public void login_Click(object sender, RoutedEventArgs e)
        {
            try
            {   
                
                if (loden1.Text == logArg && pas1.Password == parlArg)
                {
                    Window1 okno1 = new Window1();
                    okno1.Show();
                    this.Close();
                }
            }
            catch
            {
               MessageBox.Show("Ошибка!");
            }
        }

        public void reg_Click(object sender, RoutedEventArgs e)
        {
            parlArg = pas2.Password;
            logArg = loden2.Text;
            MessageBox.Show("Аккаунт создан!");
            pas2.Password = null;
            loden2.Text = null;




        }
    }
}
