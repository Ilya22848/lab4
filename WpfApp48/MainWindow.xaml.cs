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

namespace WpfApp48
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

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            int age = Convert.ToInt16(TextBoxNumberA.Text);
            string x;

            switch (age)
            {
                case 20:
                    x = "двадцать лет";
                    break;
                case 21:
                    x = "двадцать один год";
                    break;
                case 22:
                    x = "двадцать два года";
                    break;
                case 23:
                    x = "двадцать три года";
                    break;
                case 24:
                    x = "двадцать четыре года";
                    break;
                case 25:
                    x = "двадцать пять лет";
                    break;
                case 26:
                    x = "двадцать шесть лет";
                    break;
                case 27:
                    x = "двадцать семь лет";
                    break;
                case 28:
                    x = "двадцать восемь лет";
                    break;
                case 29:
                    x = "двадцать девять лет";
                    break;
                case 30:
                    x = "тридцать лет";
                    break;
                case 31:
                    x = "тридцать один год";
                    break;
                case 32:
                    x = "тридцать два года";
                    break;
                case 33:
                    x = "тридцать три года";
                    break;
                case 34:
                    x = "тридцать четыре года";
                    break;
                case 35:
                    x = "тридцать пять лет";
                    break;
                case 36:
                    x = "двадцать шесть лет";
                    break;
                case 37:
                    x = "двадцать семь лет";
                    break;
                case 38:
                    x = "двадцать восемь лет";
                    break;
                case 39:
                    x = "двадцать девять лет";
                    break;
                case 40:
                    x = "сорок лет";
                    break;
                case 41:
                    x = "сорок один год";
                    break;
                case 42:
                    x = "сорок два года";
                    break;
                case 43:
                    x = "сорок три года";
                    break;
                case 44:
                    x = "сорок четыре года";
                    break;
                case 45:
                    x = "сорок пять лет";
                    break;
                case 46:
                    x = "сорок шесть лет";
                    break;
                case 47:
                    x = "сорок семь лет";
                    break;
                case 48:
                    x = "сорок восемь лет";
                    break;
                case 49:
                    x = "сорок девять лет";
                    break;
                case 50:
                    x = "пятьдесят лет";
                    break;
                case 51:
                    x = "пятьдесят один год";
                    break;
                case 52:
                    x = "пятьдесят два года";
                    break;
                case 53:
                    x = "пятьдесят три года";
                    break;
                case 54:
                    x = "пятьдесят четыре года";
                    break;
                case 55:
                    x = "пятьдесят пять лет";
                    break;
                case 56:
                    x = "пятьдесят шесть лет";
                    break;
                case 57:
                    x = "пятьдесят семь лет";
                    break;
                case 58:
                    x = "пятьдесят восемь лет";
                    break;
                case 59:
                    x = "пятьдесят девять лет";
                    break;
                case 60:
                    x = "шестьдесят лет";
                    break;
                case 61:
                    x = "шестьдесят один год";
                    break;
                case 62:
                    x = "шестьдесят два года";
                    break;
                case 63:
                    x = "шестьдесят три года";
                    break;
                case 64:
                    x = "шестьдесят четыре года";
                    break;
                case 65:
                    x = "шестьдесят пять лет";
                    break;
                case 66:
                    x = "шестьдесят шесть лет";
                    break;
                case 67:
                    x = "шестьдесят семь лет";
                    break;
                case 68:
                    x = "шестьдесят восемь лет";
                    break;
                case 69:
                    x = "шестьдесят девять лет";
                    break;
                default:
                    x = "Неизвестный возраст";
                    break;
            }

            TextBlockAnswer.Text=(x);
        }
    }
}
