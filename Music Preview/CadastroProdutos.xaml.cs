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
using System.Windows.Shapes;

namespace Music_Preview
{
    /// <summary>
    /// Lógica interna para CadastroProdutos.xaml
    /// </summary>
    public partial class CadastroProdutos : Window
    {
        public CadastroProdutos()
        {
            InitializeComponent();
        }

        private void Voltar(object sender, MouseButtonEventArgs e)
        {
            TelaLogin window = new TelaLogin();
            window.Show();
            Hide();
        }
    }
}
