using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DS_SISPRE
{
    /// <summary>
    /// Lógica interna para Consultar_Cli.xaml
    /// </summary>
    public partial class Consultar_Cli : Window
    {
        public Consultar_Cli()
        {
            InitializeComponent();

            var clientes = new[]{
            new {nome = "José Maria", codigo = "1", ocupacao = "Cliente"},
            new {nome = "Antonio Carlos", codigo = "3", ocupacao = "Cliente"},
            new {nome = "Pedro Henrique", codigo = "4", ocupacao = "Cliente"},
            new {nome = "Augusto Cesar", codigo = "5", ocupacao = "Cliente"},
            new {nome = "Carlos Silva", codigo = "2", ocupacao= "Cliente"},
            new {nome = "", codigo = "", ocupacao= ""},
            new {nome = "", codigo = "", ocupacao= ""},
            new {nome = "", codigo = "", ocupacao= ""},
            new {nome = "", codigo = "", ocupacao= ""} };

            dataGridClientes.ItemsSource = clientes;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Cliente Excluído com Sucesso!!", "Mensagem de Confirmação");
        }
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Cliente Salvo com Sucesso!!", "Mensagem de Confirmação");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow janela = new MainWindow();
            janela.Show();
            this.Close();
        }

		private void editar_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
