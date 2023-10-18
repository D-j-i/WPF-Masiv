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

namespace WpfApp5.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page11.xaml
    /// </summary>
    public partial class Page11 : Page
    {
        public Page11()
        {
            InitializeComponent();
            Random random = new Random();

            double[] arr = new double[17];

            double a = 0;
            int ii = 0;
            


            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-99, 100);
                TbTask1.Text += $"{arr[i]} ";
                if (arr[i] >= 0 && arr[i]%2==0)
                {
                    a += arr[i];
                    ii++;
                }
            }
            TbTask2.Text += $"Сумма {a} ";
            TbTask3.Text += $"Колличество {ii} ";
        }
    }
}
