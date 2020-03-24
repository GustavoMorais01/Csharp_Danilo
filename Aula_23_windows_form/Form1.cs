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
    public partial class Form1 : Form
    
     /*
     Ordem cronológica:
     primeiro inicia os componentes. Depois carregado os mesmos.
     */   

    {
        // construtor da classe: mesmo nome(Form1-- Presta atenção)
        public Form1()
        {
            MessageBox.Show("Inicializando pelo construtor! Rocco Foda!!!");

            InitializeComponent();// Inicia todos os componentes da aplicação
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Iniciando o formulário aplicação 1.");
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "Ola Gustavo! Vc é foda camarada!!!";
        }

        private void txt_resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            var form = new FrmShow();

            // Pega o que for digitado no label do form1 e mostrar no label do FrmShow
            form.lblMensagem.Text = txt_resultado.Text;
            form.Show();

        }
    }
}
