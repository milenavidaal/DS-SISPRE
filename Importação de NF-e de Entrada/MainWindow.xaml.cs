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

namespace Importação_de_NF_e_de_Entrada
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void confirmacao_Importar(object sender, RoutedEventArgs e)
		{
			MessageBoxResult result = MessageBox.Show("Notas Importadas com Sucesso!!", "Mensagem de Confirmação");
		}

		private void alerta_Excluir(object sender, RoutedEventArgs e)
		{
			MessageBoxResult result = MessageBox.Show("Deseja realmente excluir a importação?", "Mensagem de Alerta", MessageBoxButton.YesNo, MessageBoxImage.Question);

			if (result == MessageBoxResult.Yes)
			{
				MessageBox.Show("Notas Excluídas com Sucesso");
				this.Close();
			}
       	}
	}
}
