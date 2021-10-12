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

namespace DS_SISPRE
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Vender_Produtos venda = new Vender_Produtos();
            venda.Show();
            this.Close();    
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Orcamento orcamento = new Orcamento();
            orcamento.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Controle_Relatorios controle = new Controle_Relatorios();
            controle.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Cadastrar_Cli cliente = new Cadastrar_Cli();
            cliente.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            NF_E_Entrada entrada = new NF_E_Entrada();
            entrada.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Consultar_Cli cliente = new Consultar_Cli();
            cliente.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Financas financas = new Financas();
            financas.Show();
            this.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Cadastrar_Func funcionario = new Cadastrar_Func();
            funcionario.Show();
            this.Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Cadastrar_User user = new Cadastrar_User();
            user.Show();
            this.Close();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Novo_Prod produto = new Novo_Prod();
            produto.Show();
            this.Close();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Prod_Cadastrados cadastrar = new Prod_Cadastrados();
            cadastrar.Show();
            this.Close();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Notas_Compra compra = new Notas_Compra();
            compra.Show();
            this.Close();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Contas_Receber contas = new Contas_Receber();
            contas.Show();
            this.Close();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            Recuperar_senha recuperar = new Recuperar_senha();
            recuperar.Show();
            this.Close();
        }
    }
}
