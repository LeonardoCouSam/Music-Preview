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
    /// Lógica interna para EsqueceuSenha2.xaml
    /// </summary>
    public partial class EsqueceuSenha2 : Window
    {
        int codigo;
        string email;
        EsqueceuSenha1 esqueceusenha1;
        public EsqueceuSenha2(int codigo,string email, EsqueceuSenha1 esqueceusenha1)
        {
            InitializeComponent();
            this.codigo = codigo;
            this.email = email;
            this.esqueceusenha1 = esqueceusenha1;
            
        }

        private void Voltar(object sender, MouseButtonEventArgs e)
        {
            EsqueceuSenha1 window = new EsqueceuSenha1();
            window.Show();
            Hide();
        }

        public void Botao_ConfirmaCodigo(object sender, RoutedEventArgs e)
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
                    LimpaCampos();
                    EsqueceuSenha3 window = new EsqueceuSenha3(email, this);
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
