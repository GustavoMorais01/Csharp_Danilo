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
    public partial class FrmPanel : Form
    {
        public FrmPanel()
        {
            InitializeComponent();
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O nome digitado foi: " + txtNomePnl.Text);
        }

        private void btnMostrarPanel_Click(object sender, EventArgs e)
        {
            pnlCadastro.Visible = true;
            pnlLista.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPanel_Load(object sender, EventArgs e)
        {            
            dataGridView1.DataSource = Estado.Lista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlLista.Visible = true;
            pnlCadastro.Visible = false;
        }
    }
}
