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
using System.Text.RegularExpressions;

namespace DS_SISPRE.View
{
    /// <summary>
    /// Lógica interna para Notas_Compra.xaml
    /// </summary>
    public partial class Notas_Compra : Window
    {
        public Notas_Compra()
        {
            InitializeComponent();
            
        }
        private void um_Checked(object sender, RoutedEventArgs e)
        {

            dois.IsChecked = false;
            fisica.IsEnabled = false;
            juridica.IsEnabled = true;
            fisica.Text = "";

        }

        private void dois_Checked(object sender, RoutedEventArgs e)
        {
            um.IsChecked = false;
            juridica.IsEnabled = false;
            fisica.IsEnabled = true;
            juridica.Text = "";
        }

        private void excluir_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Nota Excluída com Sucesso!!", "Mensagem de Confirmação");
        }

        private void salvar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Nota Salva com Sucesso!!", "Mensagem de Confirmação");
        }

        private void voltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow janela = new MainWindow();
            janela.Show();
            this.Close();
        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }
    }
}
