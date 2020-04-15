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
    public partial class FrmImportador : Form
    {
        private string[] lines;

        public FrmImportador()
        {
            InitializeComponent();
        }

        private void FrmImportador_Load(object sender, EventArgs e)
        {
            string filename = @"C:\dados_importar.txt";
            using (var streamReader = File.OpenText(filename))
            {

                lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries) ;
                progressBar.Maximum = lines.Length;
                progressBar.Minimum = 0;
                
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                progressBar.Value = (i + 1);

                txtLogs.Text = "Todos os logs importados!";

                // Assim mostra todos os logs.
                //txtLogs.Text += line + " - " + i + " - importado\n";
                //txtLogs.Update();

                //var user = new Usuario();
                //user.nome = line;
                //user.Save();
            }
        }
    }
}
