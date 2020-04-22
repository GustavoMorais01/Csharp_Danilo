namespace Aula_23_windows_form
{
    partial class FrmPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.Label();
            this.txtNomePnl = new System.Windows.Forms.TextBox();
            this.btnNome = new System.Windows.Forms.Button();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.btnMostrarPanel = new System.Windows.Forms.Button();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.lblLista = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.pnlCadastro.SuspendLayout();
            this.pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Location = new System.Drawing.Point(12, 11);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(38, 13);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome:";
            // 
            // txtNomePnl
            // 
            this.txtNomePnl.Location = new System.Drawing.Point(56, 8);
            this.txtNomePnl.Name = "txtNomePnl";
            this.txtNomePnl.Size = new System.Drawing.Size(100, 20);
            this.txtNomePnl.TabIndex = 1;
            // 
            // btnNome
            // 
            this.btnNome.Location = new System.Drawing.Point(184, 6);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(75, 23);
            this.btnNome.TabIndex = 2;
            this.btnNome.Text = "OK";
            this.btnNome.UseVisualStyleBackColor = true;
            this.btnNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Controls.Add(this.txtNome);
            this.pnlCadastro.Controls.Add(this.btnNome);
            this.pnlCadastro.Controls.Add(this.txtNomePnl);
            this.pnlCadastro.Location = new System.Drawing.Point(12, 83);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(306, 198);
            this.pnlCadastro.TabIndex = 3;
            this.pnlCadastro.Visible = false;
            // 
            // btnMostrarPanel
            // 
            this.btnMostrarPanel.Location = new System.Drawing.Point(12, 39);
            this.btnMostrarPanel.Name = "btnMostrarPanel";
            this.btnMostrarPanel.Size = new System.Drawing.Size(107, 23);
            this.btnMostrarPanel.TabIndex = 4;
            this.btnMostrarPanel.Text = "Mostar Cadastro";
            this.btnMostrarPanel.UseVisualStyleBackColor = true;
            this.btnMostrarPanel.Click += new System.EventHandler(this.btnMostrarPanel_Click);
            // 
            // pnlLista
            // 
            this.pnlLista.Controls.Add(this.dataGridView1);
            this.pnlLista.Controls.Add(this.lblLista);
            this.pnlLista.Location = new System.Drawing.Point(348, 83);
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.Size = new System.Drawing.Size(327, 198);
            this.pnlLista.TabIndex = 5;
            this.pnlLista.Visible = false;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(17, 11);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(29, 13);
            this.lblLista.TabIndex = 0;
            this.lblLista.Text = "Lista";
            this.lblLista.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(293, 127);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(348, 39);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(90, 23);
            this.btnMostrarLista.TabIndex = 6;
            this.btnMostrarLista.Text = "Mostrar lista";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarLista);
            this.Controls.Add(this.pnlLista);
            this.Controls.Add(this.btnMostrarPanel);
            this.Controls.Add(this.pnlCadastro);
            this.Name = "FrmPanel";
            this.Text = "FrmPanel";
            this.Load += new System.EventHandler(this.FrmPanel_Load);
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.pnlLista.ResumeLayout(false);
            this.pnlLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.TextBox txtNomePnl;
        private System.Windows.Forms.Button btnNome;
        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.Button btnMostrarPanel;
        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMostrarLista;
    }
}