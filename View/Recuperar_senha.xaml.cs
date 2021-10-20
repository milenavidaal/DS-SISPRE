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
    /// Lógica interna para Recuperar_senha.xaml
    /// </summary>
    public partial class Recuperar_senha : Window
    {
        public Recuperar_senha()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Mensagem Enviada ao seu email, verifique sua caixa de entrada!");
            Random num = new Random(); int tal;
            tal = num.Next();

            codigo.Text = Convert.ToString(tal);
        }
    }
}
