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
        string NomeConta;
        string Senha;
        string ConfirmarSenha;
        bool foiInserido;


        int codigo;    
        string email;
        CadastroProdutos CadastroProdutos;
        ConsultasUsuario ConsultasUsuario;

        public CodigoCadastro1()
        {
            InitializeComponent();
        }
        public CodigoCadastro1(int codigo, string email, string NomeConta, string Senha, String ConfirmarSenha, bool foiInserido, CadastroProdutos CadastroProdutos, ConsultasUsuario ConsultasUsuario)
        {
            InitializeComponent();
            this.foiInserido = foiInserido;
            this.NomeConta = NomeConta;
            this.Senha = Senha;
            this.ConfirmarSenha = ConfirmarSenha;
            this.codigo = codigo;
            this.email = email;
            this.CadastroProdutos = CadastroProdutos;       

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
                    bool foiInserido = cUsuario.NovoCadastro(NomeConta, Senha, ConfirmarSenha);

                    LimpaCampos();
                    TelaLogin window = new TelaLogin();
                    window.Show();
                    Hide();

                }
            }
        }
        private void LimpaCampos()
        {
            Codigo.Text = "";
        }
    }
}
