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
    /// Lógica interna para TelaLogin.xaml
    /// </summary>
    public partial class TelaLogin : Window
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void irparacadastro(object sender, RoutedEventArgs e)
        {
            CadastroProdutos Window = new CadastroProdutos();
            Window.Show();
            Hide();
        }

        private void irparaesquecisenha(object sender, MouseButtonEventArgs e)
        {
            EsqueceuSenha1 Window = new EsqueceuSenha1();
            Window.Show();
            Hide();
        }

        private void Entrar(object sender, RoutedEventArgs e)
        {
            if (NomeConta.Text == "" || Senha.Password == "")
            {
                MessageBoxResult messageBox = MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else 
            {
                string nome = NomeConta.Text;
                string senha = Senha.Password;
                Usuario usuario = cUsuario.ObterUsuarioPeloNomeSenha(nome,senha);
                if (usuario != null)
                {
                    LimpaCampos();
                    Menu Window = new Menu();
                    Window.Show();
                    Hide();
                }
                else 
                {
                    MessageBoxResult messageBox = MessageBox.Show("Senha ou nome incorretos!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void LimpaCampos() 
        {
            NomeConta.Text = "";
            Senha.Password = "";
        } 
    }
}
