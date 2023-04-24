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

namespace WpfApp66
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

            int count = 0; // счетчик количества цифр
            int sum = 0; // сумма цифр

            while (n > 0)
            {
                int digit = n % 10; // получаем последнюю цифру
                count++; // увеличиваем счетчик цифр
                sum += digit; // добавляем цифру к сумме

                n /= 10; // удаляем последнюю цифру из числа
            }

            TextBlockAnswer.Text = $"Количество цифр: {count}";
            TextBlockAnswer.Text += $"\nСумма цифр: {sum}";


        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
