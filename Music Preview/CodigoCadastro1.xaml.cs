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
    /// Lógica interna para CodigoCadastro1.xaml
    /// </summary>
    public partial class CodigoCadastro1 : Window
    {
        string nome;
        string email;
        string senha;
        int codigo;
        CadastroProdutos cadastroprodutos;

        public CodigoCadastro1(string nome, string email, string senha, int codigo, CadastroProdutos cadastroprodutos)
        {
            InitializeComponent();
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.codigo = codigo;
            this.cadastroprodutos = cadastroprodutos;
        }


        private void Botao_ConfirmaCodigo(object sender, RoutedEventArgs e)
        {

            if (Codigo.Text == "")
            {
                MessageBoxResult messageBox = MessageBox.Show("Preencha o campo!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                int codigoRecebido = Int32.Parse(Codigo.Text);

                if (codigoRecebido == codigo)
                {
                    bool foiInserido = cUsuario.NovoCadastro(nome, email, senha);

                    LimpaCampos();
                    TelaLogin window = new TelaLogin();
                    window.Show();
                    Hide();

                }
                else 
                {
                    MessageBoxResult messageBox = MessageBox.Show("Código incorreto!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void LimpaCampos()
        {
            Codigo.Text = "";
        }
    }
}
