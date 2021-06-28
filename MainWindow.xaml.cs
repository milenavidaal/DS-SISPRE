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

namespace SISPRE_Usuario
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private Pessoa pessoa = new Pessoa();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Salvar_usuario_Click(object sender, RoutedEventArgs e)
        {

            String senha, confirmasenha;

            senha = txtSenha.Password;
            confirmasenha = txtConfirmaSenha.Password;

            pessoa.Nome = txtNome.Text;
            pessoa.Data_nasc = txtData_nasc.Text;
            pessoa.Cpf = txtCpf.Text;
            pessoa.Rg = txtRg.Text;
            pessoa.Email = txtEmail.Text;

            if (pessoa.Nome.Equals(""))
            {
                MessageBox.Show("O campo Nome está vazio!!!");
            }

            if (pessoa.Data_nasc.Equals(""))
            {
                MessageBox.Show("O campo Data de Nascimento está vazio!!!");
            }
            if (pessoa.Cpf.Equals(""))
            {
                MessageBox.Show("O campo CPF está vazio!!!");
            }
            if (pessoa.Rg.Equals(""))
            {
                MessageBox.Show("O campo RG está vazio!!!");
            }
            if (pessoa.Email.Equals(""))
            {
                MessageBox.Show("O campo E-mail está vazio!!!");
            }
            if (senha.Equals(""))
            {
                MessageBox.Show("O campo Senha está vazio!!!");
            }
            if (confirmasenha.Equals(""))
            {
                MessageBox.Show("O campo Confirmar Senha está vazio!!!");
            }
            else {
                MessageBox.Show($"Nome:{ pessoa.Nome}\n" +
                    $"Data de Nascimento:{ pessoa.Data_nasc}\n" +
                    $"CPF:{ pessoa.Cpf}\n" +
                    $"RG:{ pessoa.Rg}\n" +
                    $"E-mail:{ pessoa.Email}\n");

                ClearTextBox();
            }
            
        }
        private void ClearTextBox()
        {
            txtNome.Text = "";
            txtData_nasc.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            txtEmail.Text = "";
        }

        private void Add_usuario_Click(object sender, RoutedEventArgs e)
        {
            MainWindow telacad_usuario = new MainWindow();
            telacad_usuario.ShowDialog();
        }

        private void Consultar_usuario_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_versao_Click(object sender, RoutedEventArgs e)
        {
            VersaoWindow vsDialog = new VersaoWindow();
            vsDialog.ShowDialog();
        }

        private void btn_sair_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente sair da janela?", "Janela-Cadastro de Usuário", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
                this.Close();
        }
    }
}
