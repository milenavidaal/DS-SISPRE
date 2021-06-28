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

namespace Cadastro_Estado
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private Estado estado = new Estado();
        public MainWindow()
        {
            InitializeComponent();
        }

 
        private void ClearTextBox()
        {
            txtNomeestado.Text = "";
            txtPaisestado.Text = "";
            txtSiglaestado.Text = "";
        }

        private void BtnSalvarEst_Click(object sender, RoutedEventArgs e)
        {

            estado.Nomeestado = txtNomeestado.Text;
            estado.Paisestado = txtPaisestado.Text;
            estado.Siglaestado = txtSiglaestado.Text;

            if (estado.Nomeestado.Equals(""))
            {
                MessageBox.Show("O campo Nome do Estado está vazio!!!");
            }

            if (estado.Paisestado.Equals(""))
            {
                MessageBox.Show("O campo País em que o Estado se localiza está vazio!!!");
            }
            if (estado.Siglaestado.Equals(""))
            {
                MessageBox.Show("O campo Sigla do Estado está vazio!!!");
            }

            else
            {
                MessageBox.Show($"Nome do Estado:{ estado.Nomeestado}\n" +
                    $"País em que o Estado se localiza:{ estado.Paisestado}\n" +
                    $"Sigla do Estado:{ estado.Siglaestado}");

                ClearTextBox();
            }

        }
    }
}
