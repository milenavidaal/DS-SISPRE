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

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float numa, numb, total;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void adicao(object sender, RoutedEventArgs e)
        {
            numa = Convert.ToInt32(primeiro.Text);
            numb = Convert.ToInt32(segundo.Text);
            total = numa + numb;

            result.Content = total.ToString();
        }
        private void subtracao(object sender, RoutedEventArgs e)
        {
            numa = Convert.ToInt32(primeiro.Text);
            numb = Convert.ToInt32(segundo.Text);
            total = numa - numb;

            result.Content = total.ToString();
        }
        private void divisao(object sender, RoutedEventArgs e)
        {
            numa = Convert.ToInt32(primeiro.Text);
            numb = Convert.ToInt32(segundo.Text);
            total = numa / numb;

            result.Content = total.ToString();
        }
        private void multiplicacao(object sender, RoutedEventArgs e)
        {
            numa = Convert.ToInt32(primeiro.Text);
            numb = Convert.ToInt32(segundo.Text);
            total = numa * numb;

            result.Content = total.ToString();
        }

    }
}
