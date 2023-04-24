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

namespace WpfApp65
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
            double p = Convert.ToDouble(TextBoxNumberA.Text);
            int day = 1;
            double totalDistance = 10.0;
            while (totalDistance <= 200.0)
            {
                day++;
                double distance = totalDistance * (1 + p / 100);
                totalDistance += distance;
            }
            TextBlockAnswer.Text=$"день:{day} Сумарный пробег:{totalDistance}";
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
