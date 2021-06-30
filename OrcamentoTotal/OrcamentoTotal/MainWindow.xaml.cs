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

namespace OrcamentoTotal
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
            List<Orcamento> listaOrcamento = new List<Orcamento>();


            for (int i = 1; i < 5; i++)
            {
                listaOrcamento.Add(new Orcamento()
                {
                    CodigoProduto = i + 1,
                    NomeProduto = "Produto - " + i,
                    ValorProduto = 55,
                    Quantidade = 1 + i,
                    ValorImposto = 2 * i,
                    Distribuido = " São Paulo mochilas",
                    Origem = "São Paulo",
                    ValorTotalImp = 4 * i,
                    ValorCompra = 110 * i,
                    
                });

            }

            datagridOrcamento.ItemsSource = listaOrcamento;
        }
    }
}
