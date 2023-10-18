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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();

            Random random = new Random();

            int[] arr = new int[14]; 
            int a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100); 
            }

            foreach (var item in arr)
            {
                TbTask1.Text += $"{item} ";
                if (item%2==0)
                {
                    a++;
                }

            }
            TbTask2.Text = $"Число чётных: {a}";
            int[] testArray = new int[a];

            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    testArray[j++] = arr[i];
                }
            }
            foreach (var num in testArray)
            {
                TbTask3.Text += $"{num} ";
            }
        }

        private void TbTask1_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }
    }
}
