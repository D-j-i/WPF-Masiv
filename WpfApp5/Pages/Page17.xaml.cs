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
    /// Логика взаимодействия для Page17.xaml
    /// </summary>
    public partial class Page17 : Page
    {
        public Page17()
        {
            InitializeComponent();
            Random random = new Random();

            double[] arr = new double[15];
            int SumMin = 0;
            int SumNull = 0;
            double Proz = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-99, 100);
                TbTask1.Text += $"{arr[i]} ";
                if (arr[i] < 0)
                {
                    SumMin++;
                }
                else if (arr[i] > 0) 
                {
                    Proz *= arr[i];
                }
                else
                {
                    SumNull++;
                }
            }

            TbTask2.Text += $"Кол-во отрицательных {SumMin}\nКол-во нулей {SumNull} ";
            TbTask3.Text += $"Произведение положительных {Proz} ";
        }
    }
}
