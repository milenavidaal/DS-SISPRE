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

namespace Cadastrar_Cliente
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void homem_Checked(object sender, RoutedEventArgs e)
        {
            mulher.IsChecked = false;
            homem.IsChecked = true;
        }

        private void mulher_Checked(object sender, RoutedEventArgs e)
        {
            mulher.IsChecked = true;
            homem.IsChecked = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            confirmacao confirm = new confirmacao();
            confirm.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            adicionado adicao = new adicionado();
            adicao.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            excluir delete = new excluir();
            delete.Show();
        }
    }
}
