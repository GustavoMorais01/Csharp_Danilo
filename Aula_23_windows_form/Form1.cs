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

        private void abrirLerArquivo_Click(object sender, EventArgs e)
        {
            new Frmtexto().Show();
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrir_Cadastro_Click(object sender, EventArgs e)
        {
            // Instancia o formulário de cadastro e mostra o formulario cadastro quando clicar
            new FrmCadastro().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cria variavel e instancia
            var contextMenu = new ContextMenu();
            // Dentro da instancia ele manda fazer ações como adicionar itens ao menu
            contextMenu.MenuItems.Add(new MenuItem("Abrir Ler Arquivo", abrirLerArquivo_Click));
            contextMenu.MenuItems.Add(new MenuItem("Abrir Cadastro", abrir_Cadastro_Click));
            contextMenu.MenuItems.Add(new MenuItem("Fechar", fechar_Click));
            notifyIcon.ContextMenu = contextMenu;


            atualizaHora();
                        
            // Chama o Objeto Estado e retorna a lista dos estados cadastrados. 
            cboEstados.DataSource = Estado.Lista();
            cboEstados.Text = "[Selecione]";

            //==============================================================================

            // Maneira simples
            //dataGridView.DataSource = Estado.Lista();

            // Maneira intermediaria utilizando o link
            var data = from estado in Estado.Lista()
                           // where estado.Id == 1
                       orderby estado.Nome
                       select new
                       {
                           Id = estado.Id,
                           Nome = estado.Nome

                       };

            dataGridView.DataSource = data.ToList();

            //cboEstados.Items.Clear();
            //foreach (Estado estado in Estado.Lista())
            //{
            //    cboEstados.Items.Add(estado);
            //}


            //MessageBox.Show("Iniciando o formulário aplicação 1.");
        }

        private void atualizaHora()
        {
            // Mês e hora com letras maiúsculas
            lblHoraAtual.Text = "Data/Hora atual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "Ola Gustavo! Vc é foda camarada!!! - " + ((Estado)cboEstados.SelectedItem).Id;
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

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrindo o novo arquivo de texto dentro do mdiParent
            // Foi criado uma nova classe singleton que faz a chamada =
            var frmtexto = new Frmtexto();
            frmtexto.MdiParent = MDISingleton.InstanciaMDI(); 
            frmtexto.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Para chamar formularios instanciar o formulario desejado como objeto e chamar o objeto show();
            new FrmSobre().Show();
        }

        private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Para chamar formularios instanciar o formulario desejado como objeto e chamar o objeto show();
            new FrmLicenca().Show();
        }

        private void doaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Para chamar formularios instanciar o formulario desejado como objeto e chamar o objeto show();
            new FrmDoacao().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizaHora();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criando nova instancia para fazer a chamada do formulário
            new FrmCadastro().Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cliquei no ícone\nRocco Foda!");
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Dois cliques no ícone\nIsso ai camarada!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon.ShowBalloonTip(10, "Notificação", txt_resultado.Text,ToolTipIcon.Info);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Criando instancia para chamar o MDI Parental Form
            new MDIParentPrincipal().Show();
        }
    }
}
