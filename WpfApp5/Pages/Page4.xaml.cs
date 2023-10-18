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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
            Random random = new Random();

            int[] arr = new int[10];

            int ib = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
                TbTask1.Text += $"{arr[i]} ";
            }
            
            int b = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
               
                if (arr[i] > b)
                {
                    b = arr[i];
                    ib = i;
                }
            }
            arr[ib] = arr[0];
            arr[0] = b;
            foreach (int i in arr)
            {
                TbTask3.Text += $"{i} ";
            }





        }
    }
        
}
