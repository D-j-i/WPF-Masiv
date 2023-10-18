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
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
            Random random = new Random();

            float[] arr = new float[16];

            int ia = 0, ib = 0;
            float a = 0, b = 100;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
                TbTask1.Text += $"{arr[i]} ";
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > a)
                {
                    a = arr[i];
                    ia = i;
                }
                if (arr[i] < b)
                {
                    b = arr[i];
                    ib = i;
                }
            }
            TbTask2.Text = $"Индекс максимального {ia}";
            TbTask3.Text = $"Индекс минимального {ib}";
        }
    }
}
