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
    /// Lógica interna para Controle_Relatorios.xaml
    /// </summary>
    public partial class Controle_Relatorios : Window
    {
        public Controle_Relatorios()
        {
            InitializeComponent();
        }

		


		private void Button_Click(object sender, RoutedEventArgs e)
		{
            Prod_Cadastrados cadastrar = new Prod_Cadastrados();
            cadastrar.Show();
            this.Close();
        }

		private void excluir_Click(object sender, RoutedEventArgs e)
		{
            MessageBoxResult result = MessageBox.Show("Relatório Excluído com Sucesso!!", "Mensagem de Confirmação");
        }

		private void salvar_Click(object sender, RoutedEventArgs e)
		{
            MessageBoxResult result = MessageBox.Show("Relatório Salvo com Sucesso!!", "Mensagem de Confirmação");
        }

		private void proximo_Click(object sender, RoutedEventArgs e)
		{
            MainWindow janela = new MainWindow();
            janela.Show();
            this.Close();
        }
	}
}
