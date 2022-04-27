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
    /// Lógica interna para EsqueceuSenha1.xaml
    /// </summary>
    public partial class EsqueceuSenha1 : Window
    {

        public EsqueceuSenha1()
        {
            InitializeComponent();
        }

        private void Voltar(object sender, MouseButtonEventArgs e)
        {
            TelaLogin window = new TelaLogin();
            window.Show();
            Hide();
        }

        private void EnviarEmail(object sender, RoutedEventArgs e)
        {
            if (Email.Text == "")
            {
                MessageBoxResult messageBox = MessageBox.Show("Preencha o campo!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                string email = Email.Text;
                Usuario emailusuario = cUsuario.ObterEmailEsqueceuSenha(email);
                if (emailusuario != null)
                {
                    Random random = new Random();
                    int codigo = random.Next(1, 100000);

                    LimpaCampos();
                    EnviandoCodigo(email,codigo);
                    EsqueceuSenha2 Window = new EsqueceuSenha2(codigo,email, this);
                    Window.Show();
                    Hide();
                }
                else
                {
                    MessageBoxResult messageBox = MessageBox.Show("Email incorreto!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void LimpaCampos()
        {
            Email.Text = "";
        }
        private void EnviandoCodigo(string email, int codigo) 
        {            
            MailMessage emailcodigo = new MailMessage("ojao.bolinha@gmail.com", email);

            emailcodigo.Subject = "Recuperando senha";
            emailcodigo.IsBodyHtml = true;
            emailcodigo.Body = "<p> Código: "+ codigo +"  </p>";
            emailcodigo.SubjectEncoding = Encoding.GetEncoding("UTF-8");
            emailcodigo.BodyEncoding = Encoding.GetEncoding("UTF-8");


            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com",587);

            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("musicpreviewbr@gmail.com", "musicpreview654321");

            smtpClient.EnableSsl = true;

            smtpClient.Send(emailcodigo);
        }
    }
}
