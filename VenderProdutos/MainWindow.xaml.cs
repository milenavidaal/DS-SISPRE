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

namespace VenderProdutos
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;

        }
        public void MainWindow_Loaded(object sender, RoutedEventArgs e) 
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
    }
}
