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
    /// Lógica interna para Vender_Produtos.xaml
    /// </summary>
    public partial class Vender_Produtos : Window
    {
        public Vender_Produtos()
        {
            InitializeComponent();
            Loaded += Vender_Produtos_Loaded;
        }
        public void Vender_Produtos_Loaded(object sender, RoutedEventArgs e)
        {
            List<Venda> listaVenda = new List<Venda>();

            for (int i = 0; i < 30; i++)
            {
                listaVenda.Add(new Venda()
                {
                    Item = i + 1,
                    NomeProduto = "Produto - " + i,
                    Und = 1,
                    ValorUnitario = 1 + i,
                    Quantidade = 1 + i,
                    Desconto = 0,
                    ValorTotal = 5 + i,
                });
            }

            datagridVenda.ItemsSource = listaVenda;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Compra Realizada Com Sucesso!", "Mensagem de Alerta", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Redirecionando para o menu principal");
                MainWindow janela = new MainWindow();
                janela.Show();
                this.Close();
            }
        }
    }
}
