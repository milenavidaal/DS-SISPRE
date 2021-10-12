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
    /// Lógica interna para NF_E_Entrada.xaml
    /// </summary>
    public partial class NF_E_Entrada : Window
    {
        public NF_E_Entrada()
        {
            InitializeComponent();
        }

        private void confirmacao_Importar(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Notas Importadas com Sucesso!!", "Mensagem de Confirmação");
        }

        private void alerta_Excluir(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente excluir a importação?", "Mensagem de Alerta", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Notas Excluídas com Sucesso");
                this.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow janela = new MainWindow();
            janela.Show();
            this.Close();
        }

        private void arquivo1_Checked(object sender, RoutedEventArgs e)
        {
            diretorio.IsChecked = false;
            arquivo1.IsChecked = true;
        }

        private void diretorio_Checked(object sender, RoutedEventArgs e)
        {
            diretorio.IsChecked = true;
            arquivo1.IsChecked = false;
        }
    }
}
