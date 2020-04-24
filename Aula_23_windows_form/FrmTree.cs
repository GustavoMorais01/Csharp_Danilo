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
    public partial class FrmTree : Form
    {
        public FrmTree()
        {
            InitializeComponent();
        }

        private void FrmTree_Load(object sender, EventArgs e)
        {

        }

        private void btnChecados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lerChecados(treeView1.Nodes[0]));
        }

        private string lerChecados(TreeNode node, string checkeds = "")
        {
            foreach (TreeNode n in node.Nodes)
            {
                if (n.Checked)
                {
                    checkeds += n.Text + ", ";
                }
            }

            return checkeds;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Mostra em qual node que foi clicado
            MessageBox.Show(e.Node.Text);
        }
    }
}
