namespace Aula_23_windows_form
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pressione Ok para preencher a caixa de texto";
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(63, 74);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(390, 20);
            this.txt_resultado.TabIndex = 1;
            this.txt_resultado.TextChanged += new System.EventHandler(this.txt_resultado_TextChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(63, 244);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(390, 37);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(63, 320);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(302, 31);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "Abrir nova janela";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "MG",
            "GO"});
            this.cboEstados.Location = new System.Drawing.Point(63, 158);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(390, 21);
            this.cboEstados.TabIndex = 4;
            this.cboEstados.Text = "[Selecione]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aplicação 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.Label label2;
    }
}

