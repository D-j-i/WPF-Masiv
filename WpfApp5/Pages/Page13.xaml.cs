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
    /// Логика взаимодействия для Page13.xaml
    /// </summary>
    public partial class Page13 : Page
    {
        public Page13()
        {
            InitializeComponent();
            Random random = new Random();

            double[] arr = new double[15];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-99, 100);
                TbTask1.Text += $"{arr[i]} ";

            }
            
            TbTask2.Text += $"Сумма {arr.Min()+arr.Max()} ";
            TbTask3.Text += $"Разноcть {arr.Max() - arr.Min()} ";
        }
    }
}
