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

namespace DS_SISPRE
{
    /// <summary>
    /// Lógica interna para Cadastrar_Cli.xaml
    /// </summary>
    public partial class Cadastrar_Cli : Window
    {
        public Cadastrar_Cli()
        {
            InitializeComponent();
            

            InitializeComponent();
            Random num = new Random(); int tal;
            tal = num.Next();

            cod.Text = Convert.ToString(tal);
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
            MessageBoxResult result = MessageBox.Show("Cliente Salvo com Sucesso!!", "Mensagem de Confirmação");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Cliente Adicionado com Sucesso!!", "Mensagem de Confirmação");
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
