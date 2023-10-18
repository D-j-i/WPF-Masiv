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
    /// Логика взаимодействия для Page8.xaml
    /// </summary>
    public partial class Page8 : Page
    {
        public Page8()
        {
            InitializeComponent();
            Random random = new Random();

            double[] arr = new double[16];

            double a = 0;

            

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
                TbTask1.Text += $"{arr[i]} ";
                a += arr[i];
            }
            a /= 16;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] / a;
                TbTask2.Text += $"{Math.Round(arr[i], 2)} - ";
                
            }
        }
    }
}
