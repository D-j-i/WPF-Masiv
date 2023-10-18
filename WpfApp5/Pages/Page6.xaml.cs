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
    /// Логика взаимодействия для Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        public Page6()
        {
            InitializeComponent();
            Random random = new Random();

            int[] arr = new int[20];
            int ch = 0;
            int ne = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
                TbTask1.Text += $"{arr[i]} ";
                if (arr[i]%2==0) 
                {
                    ch++;
                }
                else
                {
                    ne++;
                }
            }
            if (ch > ne)
            {
                TbTask2.Text += $"Чётных {ch}\nНечётных {ne}\nЧётных больше";
            }
            else if (ch < ne)
            {
                TbTask2.Text += $"Чётных {ch}\nНечётных {ne}\nНечётных больше";
            }
            else 
            {
                TbTask2.Text += $"Чётных {ch}\nНечётных {ne}\nЧётных и нечётных поровну";
            }
        }
    }
}
