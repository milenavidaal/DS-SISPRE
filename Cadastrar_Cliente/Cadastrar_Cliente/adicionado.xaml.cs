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

namespace Cadastrar_Cliente
{
    /// <summary>
    /// Lógica interna para adicionado.xaml
    /// </summary>
    public partial class adicionado : Window
    {
        public adicionado()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow janela = new MainWindow();
            janela.Show();
        }
    }
}
