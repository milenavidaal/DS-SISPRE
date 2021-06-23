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

namespace Notas_Compra
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
        private void um_Checked(object sender, RoutedEventArgs e)
        {

            dois.IsChecked = false;
            fisica.IsEnabled = false;
            juridica.IsEnabled = true;
            fisica.Text = "";

        }

        private void dois_Checked(object sender, RoutedEventArgs e)
        {
            um.IsChecked = false;
            juridica.IsEnabled = false;
            fisica.IsEnabled = true;
            juridica.Text = "";
        }
    }
}
