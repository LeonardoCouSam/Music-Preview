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
    /// Interaction logic for Catalogo.xaml
    /// </summary>
    public partial class Catalogo : Window
    {
        public Catalogo()
        {
            InitializeComponent();
            AtualizaDataGrid();
        }

        private void Voltar(object sender, MouseButtonEventArgs e)
        {
            Menu window = new Menu();
            window.Show();
            Hide();
        }
        private void AtualizaDataGrid()
        {
            List<CatalogoCompra> listavendas = cCatalogoCompras.CatalogoCompras();
            TabelaCatalogo.ItemsSource = listavendas;
            TabelaCatalogo.Items.Refresh();
        }
    }
}
