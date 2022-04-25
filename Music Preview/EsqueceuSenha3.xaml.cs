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
    /// Lógica interna para EsqueceuSenha3.xaml
    /// </summary>
    public partial class EsqueceuSenha3 : Window
    {
        string email;
        EsqueceuSenha2 esqueceusenha2;
        public EsqueceuSenha3(string email, EsqueceuSenha2 esqueceusenha2)
        {
            InitializeComponent();
            this.email = email;
            this.esqueceusenha2 = esqueceusenha2;
        }

        private void Voltar(object sender, MouseButtonEventArgs e)
        {
            TelaLogin window = new TelaLogin();
            window.Show();
            Hide();
        }

        private void Botao_NovaSenha(object sender, RoutedEventArgs e)
        {
            

            if( NovaSenha.Password == "" || ConfirmaSenha.Password == "")
            {
                MessageBoxResult messageBox = MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                string novasenha = NovaSenha.Password;
                string confirmasenha = ConfirmaSenha.Password;
                bool senhaAlterada = cUsuario.RededefinirSenha(email,novasenha);
                if (novasenha == confirmasenha)
                {
                    LimpaCampos();
                    TelaLogin Window = new TelaLogin();
                    Window.Show();
                    Hide();
                }
                else
                {
                    MessageBoxResult messageBox = MessageBox.Show("Senha incorreta", "Atenção", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void LimpaCampos()
        {
            NovaSenha.Password = "";
            ConfirmaSenha.Password = "";
        }
    }
}
