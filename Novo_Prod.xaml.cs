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
    /// Lógica interna para Novo_Prod.xaml
    /// </summary>
    public partial class Novo_Prod : Window
    {
        public Novo_Prod()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
           
                MessageBoxResult result = MessageBox.Show("Produtos Salvados com Sucesso!!", "Mensagem de Confirmação");
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow janela = new MainWindow();
            janela.Show();
            this.Close();
        }
    }
}
