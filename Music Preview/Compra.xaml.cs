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
using System.Windows.Shapes;

namespace Music_Preview
{
    /// <summary>
    /// Interaction logic for Compra.xaml
    /// </summary>
    public partial class Compra : Window
    {
        public Compra()
        {
            InitializeComponent();
        }

        private void Voltar(object sender, MouseButtonEventArgs e)
        {
            Menu window = new Menu();
            window.Show();
            Hide();
        }

        private void FinalizarCompra(object sender, RoutedEventArgs e)
        {
            Menu window = new Menu();
            window.Show();
            Hide();
        }
    }
}
