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
        public EsqueceuSenha3()
        {
            InitializeComponent();
        }

        private void Voltar(object sender, MouseButtonEventArgs e)
        {
            EsqueceuSenha3 window = new EsqueceuSenha3();
            window.Show();
            Hide();
        }
    }
}
