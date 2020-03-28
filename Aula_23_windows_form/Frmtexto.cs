using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_23_windows_form
{
    public partial class Frmtexto : Form
    {
        public Frmtexto()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }

        private void SalvarArquivo()
        {
            // Importar o System.IO
            // Colocar Caminho e os Dados que vou mandar
            File.WriteAllText(@"c:\texto_"+ DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss") + ".txt", txtTexto.Text);
            MessageBox.Show("Arquivo Salvo!");
            txtTexto.Text = string.Empty;
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }
    }
}
