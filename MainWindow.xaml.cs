﻿using System;
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

namespace SISPRE_Usuario
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Salvar_usuario_Click(object sender, RoutedEventArgs e)
        {

          
        }


        private void Add_usuario_Click(object sender, RoutedEventArgs e)
        {
            MainWindow janela = new MainWindow();
            janela.ShowDialog();
        }

        private void Consultar_usuario_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
