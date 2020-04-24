using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_23_windows_form
{
    public partial class FrmWebBronwser : Form
    {
        public FrmWebBronwser()
        {
            InitializeComponent();
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            // Chamada para o facebbok com o click do botão.
            webBrowser1.Url = new Uri("http://www.facebook.com.br");
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            // Chamada para o youtube com o click do botão.
            webBrowser1.Url = new Uri("http://www.youtube.com.br");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // Botão fecha o formulário.
            this.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Tira os botões de fechar e maxmilizar
            // Deixa a tela maximilizada
            // Tira as bordas para evitar que o usuário so mexa na tela e pronto.
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
