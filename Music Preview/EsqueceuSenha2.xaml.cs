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
        public EsqueceuSenha2()
        {
            InitializeComponent();
        }

        private void Voltar(object sender, MouseButtonEventArgs e)
        {
            EsqueceuSenha1 window = new EsqueceuSenha1();
            window.Show();
            Hide();
        }
    }
}
