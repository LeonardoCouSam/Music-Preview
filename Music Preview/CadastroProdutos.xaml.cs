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
using System.Net.Mail;
using System.Net;

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
        private void EnviandoCodigoCadastro(string email, int codigo)
        {
            MailMessage emailcodigo = new MailMessage("musicpreviewbt@gmail.com", email);

            emailcodigo.Subject = "Confirmando Cadastro";
            emailcodigo.IsBodyHtml = true;
            emailcodigo.Body = "<p> Código: " + codigo + "  </p>";
            emailcodigo.SubjectEncoding = Encoding.GetEncoding("UTF-8");
            emailcodigo.BodyEncoding = Encoding.GetEncoding("UTF-8");

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("musicpreviewbr@gmail.com", "musicpreview654321");
            smtpClient.EnableSsl = true;
            smtpClient.Send(emailcodigo);
        }

        private void Voltar(object sender, MouseButtonEventArgs e)
        {
            TelaLogin window = new TelaLogin();
            window.Show();
            Hide();
        }
        private void LimpaCampos()
        {
            Email.Text = "";
            NomeConta.Text = "";
            Senha.Password = "";
            ConfirmarSenha.Password = "";

        }

        private void Click_Cadastro(object sender, RoutedEventArgs e)
        {
            if (NomeConta.Text == "" || Senha.Password == "" || ConfirmarSenha.Password == "")
            {
                MessageBoxResult messageBox = MessageBox.Show("Preencha todos os campos!", "Atenção!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            else if (Senha.Password == ConfirmarSenha.Password)
            {
                string senha = Senha.Password;
                string confirmasenha = ConfirmarSenha.Password;
                string nome = NomeConta.Text;
                string email = Email.Text;
                Random random = new Random();              
                int codigo = random.Next(1, 100000);
                LimpaCampos();
                EnviandoCodigoCadastro(email, codigo);
               

                CodigoCadastro1 window = new CodigoCadastro1(nome, email, senha, codigo, this);
                window.Show();
                Hide();


            }
        }
    }
}
