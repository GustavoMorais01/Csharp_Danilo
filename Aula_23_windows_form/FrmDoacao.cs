using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_23_windows_form
{
    public partial class FrmDoacao : Form
    {
        public FrmDoacao()
        {
            InitializeComponent();
        }

        private void btnDoacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Doe 200 milhões de reais para Gustavo Morais");

            // Link de direcionamento para site de pagamento ou qualquer outra coisa que precisar
            // Encostar o mouse no Process e chamar com a seta pa importar o System diagnostics
            Process.Start("http://www.sitedorocco.com.br");
        }
    }
}
