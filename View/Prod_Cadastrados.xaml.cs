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
    /// Lógica interna para Prod_Cadastrados.xaml
    /// </summary>
    public partial class Prod_Cadastrados : Window
    {
        public Prod_Cadastrados()
        {
            InitializeComponent();
			Loaded += Prod_Cadastrados_Loaded;
		}
		public void Prod_Cadastrados_Loaded(object sender, RoutedEventArgs e)
		{

			txtDatinha.Text = DateTime.Now.ToString("dd/MM/yyyy");

			List<Todos_Produtos> listaTodos_Produtos = new List<Todos_Produtos>();

			listaTodos_Produtos.Add(new Todos_Produtos()
			{
				id = 21564,
				Nome_Produto = "Boneca Barbie",
				Valor_Unitario = 95.00,
				Quantidade = 18

			});

			listaTodos_Produtos.Add(new Todos_Produtos()
			{
				id = 75800,
				Nome_Produto = "Boneco Max Steel",
				Valor_Unitario = 80.00,
				Quantidade = 13

			});

			listaTodos_Produtos.Add(new Todos_Produtos()
			{
				id = 42226,
				Nome_Produto = "Carrinhos Hotwheels Diversos",
				Valor_Unitario = 9.00,
				Quantidade = 54

			});

			listaTodos_Produtos.Add(new Todos_Produtos()
			{
				id = 75726,
				Nome_Produto = "Ursos de Pelúcia",
				Valor_Unitario = 20.00,
				Quantidade = 28

			});

			listaTodos_Produtos.Add(new Todos_Produtos()
			{
				id = 58526,
				Nome_Produto = "Miniaturas Infantis",
				Valor_Unitario = 17.00,
				Quantidade = 13

			});

			dataGridProdutos.ItemsSource = listaTodos_Produtos;

		}
	
}
}
