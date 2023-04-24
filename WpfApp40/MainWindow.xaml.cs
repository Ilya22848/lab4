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
using static System.Math;

namespace WpfApp40
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
            int k = Convert.ToInt16(TextBoxNumberA.Text);
            string x;

            switch(k)
            {
                case 1:
                    x = "плохо";
                    break;
                case 2:
                    x = "неудовлетворительно";
                    break;
                case 3:
                    x = "удовлетворительно";
                    break;
                case 4:
                    x = "хорошо";
                    break;
                case 5:
                    x = "отлично";
                    break;
                default:
                    x = "ошибка";
                    break;
            }
            TextBlockAnswer.Text = $"{x}";
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
