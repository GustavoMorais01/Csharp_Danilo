namespace Aula_23_windows_form
{
    partial class FrmLicenca
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
            this.btnObterLicenca = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnObterLicenca
            // 
            this.btnObterLicenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObterLicenca.Location = new System.Drawing.Point(59, 58);
            this.btnObterLicenca.Name = "btnObterLicenca";
            this.btnObterLicenca.Size = new System.Drawing.Size(174, 53);
            this.btnObterLicenca.TabIndex = 0;
            this.btnObterLicenca.Text = "Obter Licença";
            this.btnObterLicenca.UseVisualStyleBackColor = true;
            this.btnObterLicenca.Click += new System.EventHandler(this.btnObterLicenca_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(483, 120);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(144, 35);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(59, 129);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(418, 20);
            this.txtChave.TabIndex = 2;
            this.txtChave.Text = "Chave de acesso:";
            // 
            // FrmLicenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 541);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnObterLicenca);
            this.Name = "FrmLicenca";
            this.Text = "FrmLicenca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObterLicenca;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtChave;
    }
}