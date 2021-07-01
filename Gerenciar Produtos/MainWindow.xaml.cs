using Gerenciar_Produtos.Dominio.Produto;
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

namespace Gerenciar_Produtos
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			Loaded += MainWindow_Loaded;
			
		}

		private void MainWindow_Loaded(object sender, RoutedEventArgs e)
		{
			txtDatinha.Text = DateTime.Now.ToString("dd/MM/yyyy");

			List<Produto> listaProduto = new List<Produto>();

			listaProduto.Add(new Produto()
			{
				Nome_Produto = "Boneca Barbie",
				Valor_Unitario = 95.00,
				Quantidade = 18
		
			});

			listaProduto.Add(new Produto()
			{
				Nome_Produto = "Boneco Max Steel",
				Valor_Unitario = 80.00,
				Quantidade = 13

			});

			listaProduto.Add(new Produto()
			{
				Nome_Produto = "Carrinhos Hotwheels Diversos",
				Valor_Unitario = 9.00,
				Quantidade = 54

			});

			listaProduto.Add(new Produto()
			{
				Nome_Produto = "Ursos de Pelúcia",
				Valor_Unitario = 20.00,
				Quantidade = 28

			});

			listaProduto.Add(new Produto()
			{
				Nome_Produto = "Miniaturas Infantis",
				Valor_Unitario = 17.00,
				Quantidade = 13

			});

			dataGridProdutos.ItemsSource = listaProduto;
		}
	}
}
