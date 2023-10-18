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
    /// Логика взаимодействия для Page16.xaml
    /// </summary>
    public partial class Page16 : Page
    {
        public Page16()
        {
            InitializeComponent();
            Random random = new Random();

            double[] arr = new double[14];
            int iMax = 0;
            int iMin = 0;
            int Sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-99, 100);
                TbTask1.Text += $"{arr[i]} ";

            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr.Min())
                {
                    iMin = i;
                }
                if (arr[i] == arr.Max())
                {
                    iMax = i;
                }

            }
            if (iMin<iMax)
            {
                for (int i = iMin+1; i < iMax; i++)
                {
                    Sum++;

                }
            }
            else
            {
                for (int i = iMax + 1; i < iMin; i++)
                {
                    Sum++;

                }
            }
            TbTask2.Text += $"Min = {arr[iMin]}      Max = {arr[iMax]}";
            TbTask3.Text += $"Кол-во чисел между Min и Max {Sum}";
        }
    }
}
