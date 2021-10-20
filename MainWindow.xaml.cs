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
using DS_SISPRE.Models;
using DS_SISPRE.Database;


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

            Loaded += MainWindow_Loaded;
        }

       

        private void MainWindow_Loaded(object sander, RoutedEventArgs e)
        {
            try
            {
                var connexao = new Conexao();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                       
        }    


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            View.Vender_Produtos venda = new View.Vender_Produtos();
            venda.Show();
            this.Close();    
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            View.Orcamento orcamento = new View.Orcamento();
            orcamento.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            View.Controle_Relatorios controle = new View.Controle_Relatorios();
            controle.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            View.Cadastrar_Cliente cliente = new View.Cadastrar_Cliente();
            cliente.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            View.NFE_Entrada entrada = new View.NFE_Entrada();
            entrada.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            View.Consultar_Cliente cliente = new View.Consultar_Cliente();
            cliente.Show();
            this.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            View.Cadastrar_Funcionario funcionario = new View.Cadastrar_Funcionario();
            funcionario.Show();
            this.Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            View.Cadastrar_Usuario user = new View.Cadastrar_Usuario();
            user.Show();
            this.Close();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            View.Novo_Produto produto = new View.Novo_Produto();
            produto.Show();
            this.Close();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            View.Prod_Cadastrados cadastrar = new View.Prod_Cadastrados();
            cadastrar.Show();
            this.Close();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            View.Notas_Compra compra = new View.Notas_Compra();
            compra.Show();
            this.Close();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            View.Contas_Receber contas = new View.Contas_Receber();
            contas.Show();
            this.Close();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            View.Recuperar_senha recuperar = new View.Recuperar_senha();
            recuperar.Show();
            this.Close();
        }
    }
}
