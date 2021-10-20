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

namespace DS_SISPRE.View
{
    /// <summary>
    /// Lógica interna para Orcamento.xaml
    /// </summary>
    public partial class Orcamento : Window
    {
        public Orcamento()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        public int CodigoProduto { get; private set; }
        public string NomeProduto { get; private set; }
        public int ValorProduto { get; private set; }
        public int Quantidade { get; private set; }
        public int ValorImposto { get; private set; }
        public string Distribuido { get; private set; }
        public string Origem { get; private set; }
        public int ValorTotalImp { get; private set; }
        public int ValorCompra { get; private set; }

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow janela = new MainWindow();
            janela.Show();
            this.Close();
        }
    }
}
