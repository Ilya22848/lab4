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

namespace WpfApp50
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {

            double P = Convert.ToDouble(TextBoxNumberA.Text);
            double distance = 10;
            int day = 1;
            double sum = distance;
            while (sum <= 200)
            {

                day++;
                distance *= (1 + P / 100);
                sum += distance;
            }
            TextBlockAnswer.Text = $"{day}";
            TextBlockAnswer.Text += $"\n{Math.Round(sum,4)}";
            
        }
        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
