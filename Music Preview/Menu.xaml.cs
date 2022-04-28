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
    /// Lógica interna para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {

        public Menu()
        {
            InitializeComponent();
            AtualizaDataGrid();
            AtualizaDataGrid2();

        }

        private void Botao_Biblioteca(object sender, MouseButtonEventArgs e)
        {
            Biblioteca window = new Biblioteca();
            window.Show();
            Hide();
        }

        private void Botao_Suporte(object sender, MouseButtonEventArgs e)
        {
            Suporte window = new Suporte();
            window.Show();
            Hide();
        }

        private void Botao_Catalogo(object sender, RoutedEventArgs e)
        {
            Catalogo window = new Catalogo();
            window.Show();
            Hide();
        }

        private void Botao_EnviarSugestao(object sender, RoutedEventArgs e)
        {
            string nomeMusica = NomeMusica.Text;
            string nomeArtista = NomeArtista.Text;

            if (nomeMusica == "" || nomeArtista == "")
            {
                MessageBoxResult messageBox = MessageBox.Show("Preencha todos os campos obrigatórios!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else
            {
                bool foiInserido = cSugestaoMusica.NovaMusica(nomeMusica, nomeArtista);
                LimpaCampos();

            }
        }

        private void Botao_Producao(object sender, RoutedEventArgs e)
        {
            Producao window = new Producao();
            window.Show();
            Hide();
        }

        private void Botao_TelaSugeridos(object sender, RoutedEventArgs e)
        {
            Sugestao window = new Sugestao();
            window.Show();
            Hide();
        }

        private void LogOut(object sender, MouseButtonEventArgs e)
        {
            TelaLogin window = new TelaLogin();
            window.Show();
            Hide();
        }
        private void LimpaCampos()
        {
            NomeMusica.Text = "";
            NomeArtista.Text = "";
        }
        private void AtualizaDataGrid()
        {
            List<SugestaoMusica> listasugestao = cSugestaoMusica.ObterTodasSugestoes();
            TabelaTopSugestao.ItemsSource = listasugestao;
            TabelaTopSugestao.Items.Refresh();
        }
        private void AtualizaDataGrid2()
        {
            List<ProducaoProdutora> listaproducao = cProducaoProdutora.ObterTodasProducoes();
            TabelaTopProducao.ItemsSource = listaproducao;
            TabelaTopProducao.Items.Refresh();
        }

        private void Botao_Comprar(object sender, MouseButtonEventArgs e)
        {
            Compra window = new Compra();
            window.Show();
            Hide();        
        }
    }
}

