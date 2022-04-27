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
    /// Interaction logic for Suporte.xaml
    /// </summary>
    public partial class Suporte : Window
    {
        public Suporte()
        {
            InitializeComponent();
        }

        private void Voltar(object sender, MouseButtonEventArgs e)
        {
            Menu window = new Menu();
            window.Show();
            Hide();
        }

        private void BotaoEnviaEmail(object sender, RoutedEventArgs e)
        {
            string email = Email.Text;
            string senhaEmail = SenhaEmail.Password;
            string titulo = Assunto.Text;
            string mensagem = Mensagem.Text;

            if (email == "" || senhaEmail == "" || titulo == "" || mensagem == "")
            {
                MessageBoxResult messageBox = MessageBox.Show("Preencha todos os campos!", "Atenção!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else 
            {
                MailMessage emailsuporte = new MailMessage(email, "musicpreviewbr@gmail.com");

                emailsuporte.Subject = titulo;
                emailsuporte.IsBodyHtml = true;
                emailsuporte.Body = "<p>" + mensagem + "</p>";
                emailsuporte.SubjectEncoding = Encoding.GetEncoding("UTF-8");
                emailsuporte.BodyEncoding = Encoding.GetEncoding("UTF-8");

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(email, senhaEmail);
                smtpClient.EnableSsl = true;
                smtpClient.Send(emailsuporte);

                MessageBoxResult messageBox = MessageBox.Show("Email Enviado com sucesso!", "Tudo certo", MessageBoxButton.OK, MessageBoxImage.Exclamation);

                Menu window = new Menu();
                window.Show();
                Hide();
            }





        }
    }
}
