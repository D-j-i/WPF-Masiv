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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            Random random = new Random();

            int[] arr = new int[12];
            int a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
                a += arr[i]; 
            }



            foreach (var num in arr)
            {
                TbTask1.Text += $"{num} ";
            }
            arr[4] = a / 12;
            foreach (var num in arr)
            {
                TbTask3.Text += $"{num} ";
            }
        }
    }
}
