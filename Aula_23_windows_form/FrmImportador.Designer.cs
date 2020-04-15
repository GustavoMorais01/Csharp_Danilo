namespace Aula_23_windows_form
{
    partial class FrmImportador
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnImportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(57, 71);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(452, 75);
            this.progressBar.TabIndex = 0;
            // 
            // btnImportar
            // 
            this.btnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.Location = new System.Drawing.Point(57, 398);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(452, 33);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clique no botão para atualizar os dados.";
            // 
            // txtLogs
            // 
            this.txtLogs.Enabled = false;
            this.txtLogs.Location = new System.Drawing.Point(57, 152);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.Size = new System.Drawing.Size(452, 230);
            this.txtLogs.TabIndex = 3;
            // 
            // FrmImportador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 460);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.progressBar);
            this.Name = "FrmImportador";
            this.Text = "FrmImportador";
            this.Load += new System.EventHandler(this.FrmImportador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogs;
    }
}