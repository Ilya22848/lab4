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

namespace WpfApp49
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
            int n = Convert.ToInt16(TextBoxNumberA.Text);
            double value = Convert.ToDouble(TextBoxNumberC.Text);
            double a, c, h, s;

            switch (n)
            {
                case 1: // катет a
                    a = value;
                    c = a * Math.Sqrt(2);
                    h = c / 2;
                    s = c * h / 2;
                    TextBlockAnswer.Text = $"Катет a = {a}";
                    TextBlockAnswer.Text += $"\nГипотенуза c = {c}";
                    TextBlockAnswer.Text += $"\nВысота h = {h}";
                    TextBlockAnswer.Text += $"\nПлощадь S = {s}";
                    break;
                case 2: // гипотенуза c
                    c = value;
                    a = c / Math.Sqrt(2);
                    h = c / 2;
                    s = c * h / 2;
                    TextBlockAnswer.Text = $"Катет a = {a}";
                    TextBlockAnswer.Text += $"\nГипотенуза c = {c}";
                    TextBlockAnswer.Text += $"\nВысота h = {h}";
                    TextBlockAnswer.Text += $"\nПлощадь S = {s}"; ;
                    break;
                case 3: // высота h
                    h = value;
                    c = h * 2;
                    a = c / Math.Sqrt(2);
                    s = c * h / 2;
                    TextBlockAnswer.Text = $"Катет a = {a}";
                    TextBlockAnswer.Text += $"\nГипотенуза c = {c}";
                    TextBlockAnswer.Text += $"\nВысота h = {h}";
                    TextBlockAnswer.Text += $"\nПлощадь S = {s}";
                    break;
                case 4: // площадь S
                    s = value;
                    c = Math.Sqrt(s * 2);
                    h = s * 2 / c;
                    a = c / Math.Sqrt(2);
                    TextBlockAnswer.Text = $"Катет a = {a}";
                    TextBlockAnswer.Text += $"\nГипотенуза c = {c}";
                    TextBlockAnswer.Text += $"\nВысота h = {h}";
                    TextBlockAnswer.Text += $"\nПлощадь S = {s}";
                    break;
                default:
                    TextBlockAnswer.Text ="Ошибка ввода";
                    break;
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
