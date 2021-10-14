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
    /// Lógica interna para Cadastrar_User.xaml
    /// </summary>
    public partial class Cadastrar_User : Window
    {
        public Cadastrar_User()
        {
            InitializeComponent();
            Random num = new Random(); int tal;
            tal = num.Next();

            codigo.Text = Convert.ToString(tal);
            
        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void func_Checked(object sender, RoutedEventArgs e)
        {
            cliente.IsChecked = false;
            func.IsChecked = true;
        }

        private void cliente_Checked(object sender, RoutedEventArgs e)
        {
            cliente.IsChecked = true;
            func.IsChecked = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Todos os dados não salvos serão perdidos, deseja adicionar novo usuário?", "Mensagem de Alerta", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Preencha os campos a seguir");                
                rg.Text = "";
                nome.Text = "";
                email.Text = "";
                cpf.Text = "";
                senha.Text = "";
                senha2.Text = "";

                
                Random num = new Random(); int tal;
                tal = num.Next();

                codigo.Text = Convert.ToString(tal);
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow janela = new MainWindow();
            janela.Show();
            this.Hide();
        }

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
            MessageBoxResult result = MessageBox.Show("Usuário Salvo com Sucesso!!", "Mensagem de Confirmação");
        }
	}

}
