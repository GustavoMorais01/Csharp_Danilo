namespace Aula_23_windows_form
{
    partial class FrmTabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnTabBasico = new System.Windows.Forms.Button();
            this.txtNumeroBasico01 = new System.Windows.Forms.TextBox();
            this.lblNumeroBasico1 = new System.Windows.Forms.Label();
            this.txtNomeBasico = new System.Windows.Forms.TextBox();
            this.lblNomeBasico = new System.Windows.Forms.Label();
            this.txtNumeroBasico2 = new System.Windows.Forms.TextBox();
            this.lblNumeroBasico2 = new System.Windows.Forms.Label();
            this.btnEssencia1 = new System.Windows.Forms.Button();
            this.txtEssencia2 = new System.Windows.Forms.TextBox();
            this.lblNumeroEssencia = new System.Windows.Forms.Label();
            this.txtEssencia1 = new System.Windows.Forms.TextBox();
            this.lblEssencia = new System.Windows.Forms.Label();
            this.btnPagamento1 = new System.Windows.Forms.Button();
            this.txtPagamento1 = new System.Windows.Forms.TextBox();
            this.lblPagamento1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 363);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtNumeroBasico2);
            this.tabPage1.Controls.Add(this.lblNumeroBasico2);
            this.tabPage1.Controls.Add(this.btnTabBasico);
            this.tabPage1.Controls.Add(this.txtNumeroBasico01);
            this.tabPage1.Controls.Add(this.lblNumeroBasico1);
            this.tabPage1.Controls.Add(this.txtNomeBasico);
            this.tabPage1.Controls.Add(this.lblNomeBasico);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados básicos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEssencia1);
            this.tabPage2.Controls.Add(this.txtEssencia2);
            this.tabPage2.Controls.Add(this.lblNumeroEssencia);
            this.tabPage2.Controls.Add(this.txtEssencia1);
            this.tabPage2.Controls.Add(this.lblEssencia);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados essenciais";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnPagamento1);
            this.tabPage3.Controls.Add(this.txtPagamento1);
            this.tabPage3.Controls.Add(this.lblPagamento1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dados do pagamento do cliente";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnTabBasico
            // 
            this.btnTabBasico.Location = new System.Drawing.Point(197, 225);
            this.btnTabBasico.Name = "btnTabBasico";
            this.btnTabBasico.Size = new System.Drawing.Size(203, 23);
            this.btnTabBasico.TabIndex = 11;
            this.btnTabBasico.Text = "Calcular";
            this.btnTabBasico.UseVisualStyleBackColor = true;
            // 
            // txtNumeroBasico01
            // 
            this.txtNumeroBasico01.Location = new System.Drawing.Point(300, 129);
            this.txtNumeroBasico01.Name = "txtNumeroBasico01";
            this.txtNumeroBasico01.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroBasico01.TabIndex = 10;
            // 
            // lblNumeroBasico1
            // 
            this.lblNumeroBasico1.AutoSize = true;
            this.lblNumeroBasico1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroBasico1.Location = new System.Drawing.Point(193, 125);
            this.lblNumeroBasico1.Name = "lblNumeroBasico1";
            this.lblNumeroBasico1.Size = new System.Drawing.Size(84, 24);
            this.lblNumeroBasico1.TabIndex = 9;
            this.lblNumeroBasico1.Text = "Número:";
            // 
            // txtNomeBasico
            // 
            this.txtNomeBasico.Location = new System.Drawing.Point(300, 79);
            this.txtNomeBasico.Name = "txtNomeBasico";
            this.txtNomeBasico.Size = new System.Drawing.Size(100, 20);
            this.txtNomeBasico.TabIndex = 8;
            // 
            // lblNomeBasico
            // 
            this.lblNomeBasico.AutoSize = true;
            this.lblNomeBasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeBasico.Location = new System.Drawing.Point(193, 74);
            this.lblNomeBasico.Name = "lblNomeBasico";
            this.lblNomeBasico.Size = new System.Drawing.Size(67, 24);
            this.lblNomeBasico.TabIndex = 7;
            this.lblNomeBasico.Text = "Nome:";
            // 
            // txtNumeroBasico2
            // 
            this.txtNumeroBasico2.Location = new System.Drawing.Point(300, 175);
            this.txtNumeroBasico2.Name = "txtNumeroBasico2";
            this.txtNumeroBasico2.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroBasico2.TabIndex = 13;
            // 
            // lblNumeroBasico2
            // 
            this.lblNumeroBasico2.AutoSize = true;
            this.lblNumeroBasico2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroBasico2.Location = new System.Drawing.Point(193, 171);
            this.lblNumeroBasico2.Name = "lblNumeroBasico2";
            this.lblNumeroBasico2.Size = new System.Drawing.Size(84, 24);
            this.lblNumeroBasico2.TabIndex = 12;
            this.lblNumeroBasico2.Text = "Número:";
            // 
            // btnEssencia1
            // 
            this.btnEssencia1.Location = new System.Drawing.Point(285, 216);
            this.btnEssencia1.Name = "btnEssencia1";
            this.btnEssencia1.Size = new System.Drawing.Size(203, 23);
            this.btnEssencia1.TabIndex = 18;
            this.btnEssencia1.Text = "Calcular";
            this.btnEssencia1.UseVisualStyleBackColor = true;
            // 
            // txtEssencia2
            // 
            this.txtEssencia2.Location = new System.Drawing.Point(388, 168);
            this.txtEssencia2.Name = "txtEssencia2";
            this.txtEssencia2.Size = new System.Drawing.Size(100, 20);
            this.txtEssencia2.TabIndex = 17;
            // 
            // lblNumeroEssencia
            // 
            this.lblNumeroEssencia.AutoSize = true;
            this.lblNumeroEssencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroEssencia.Location = new System.Drawing.Point(281, 164);
            this.lblNumeroEssencia.Name = "lblNumeroEssencia";
            this.lblNumeroEssencia.Size = new System.Drawing.Size(84, 24);
            this.lblNumeroEssencia.TabIndex = 16;
            this.lblNumeroEssencia.Text = "Número:";
            // 
            // txtEssencia1
            // 
            this.txtEssencia1.Location = new System.Drawing.Point(388, 118);
            this.txtEssencia1.Name = "txtEssencia1";
            this.txtEssencia1.Size = new System.Drawing.Size(100, 20);
            this.txtEssencia1.TabIndex = 15;
            // 
            // lblEssencia
            // 
            this.lblEssencia.AutoSize = true;
            this.lblEssencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEssencia.Location = new System.Drawing.Point(281, 113);
            this.lblEssencia.Name = "lblEssencia";
            this.lblEssencia.Size = new System.Drawing.Size(67, 24);
            this.lblEssencia.TabIndex = 14;
            this.lblEssencia.Text = "Nome:";
            // 
            // btnPagamento1
            // 
            this.btnPagamento1.Location = new System.Drawing.Point(285, 240);
            this.btnPagamento1.Name = "btnPagamento1";
            this.btnPagamento1.Size = new System.Drawing.Size(203, 23);
            this.btnPagamento1.TabIndex = 23;
            this.btnPagamento1.Text = "Calcular";
            this.btnPagamento1.UseVisualStyleBackColor = true;
            // 
            // txtPagamento1
            // 
            this.txtPagamento1.Location = new System.Drawing.Point(388, 142);
            this.txtPagamento1.Name = "txtPagamento1";
            this.txtPagamento1.Size = new System.Drawing.Size(100, 20);
            this.txtPagamento1.TabIndex = 20;
            // 
            // lblPagamento1
            // 
            this.lblPagamento1.AutoSize = true;
            this.lblPagamento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamento1.Location = new System.Drawing.Point(281, 137);
            this.lblPagamento1.Name = "lblPagamento1";
            this.lblPagamento1.Size = new System.Drawing.Size(67, 24);
            this.lblPagamento1.TabIndex = 19;
            this.lblPagamento1.Text = "Nome:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tab 01";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tab 02";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(316, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tab 03";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmTabControl";
            this.Text = "FrmTabControl";
            this.Load += new System.EventHandler(this.FrmTabControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtNumeroBasico2;
        private System.Windows.Forms.Label lblNumeroBasico2;
        private System.Windows.Forms.Button btnTabBasico;
        private System.Windows.Forms.TextBox txtNumeroBasico01;
        private System.Windows.Forms.Label lblNumeroBasico1;
        private System.Windows.Forms.TextBox txtNomeBasico;
        private System.Windows.Forms.Label lblNomeBasico;
        private System.Windows.Forms.Button btnEssencia1;
        private System.Windows.Forms.TextBox txtEssencia2;
        private System.Windows.Forms.Label lblNumeroEssencia;
        private System.Windows.Forms.TextBox txtEssencia1;
        private System.Windows.Forms.Label lblEssencia;
        private System.Windows.Forms.Button btnPagamento1;
        private System.Windows.Forms.TextBox txtPagamento1;
        private System.Windows.Forms.Label lblPagamento1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}